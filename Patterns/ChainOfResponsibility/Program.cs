// Chain of Responsibility demo consolidated into Program.cs

// Request model
public class Request
{
    public bool IsAuthenticated { get; set; }
    public bool IsValid { get; set; }
    public string Data { get; set; } = string.Empty;
}

// Base handler
public abstract class Handler
{
    private Handler? _next;
    public Handler SetNext(Handler next) { _next = next; return next; }
    public bool Handle(Request request)
    {
        if (Process(request)) return true;
        if (_next != null) return _next.Handle(request);
        return false;
    }
    protected abstract bool Process(Request request);
}

public class AuthHandler : Handler
{
    protected override bool Process(Request request)
    {
        if (!request.IsAuthenticated)
        {
            Console.WriteLine("AuthHandler: Authentication failed. Stopping chain.");
            return true;
        }
        Console.WriteLine("AuthHandler: Authenticated. Passing to next.");
        return false;
    }
}

public class ValidationHandler : Handler
{
    protected override bool Process(Request request)
    {
        if (!request.IsValid)
        {
            Console.WriteLine("ValidationHandler: Validation failed. Stopping chain.");
            return true;
        }
        Console.WriteLine("ValidationHandler: Valid. Passing to next.");
        return false;
    }
}

public class ProcessingHandler : Handler
{
    protected override bool Process(Request request)
    {
        Console.WriteLine($"ProcessingHandler: Processing data '{request.Data}'");
        return true;
    }
}

// Build a chain: AuthHandler -> ValidationHandler -> ProcessingHandler
var auth = new AuthHandler();
auth.SetNext(new ValidationHandler()).SetNext(new ProcessingHandler());

var requests = new[]
{
    new Request { IsAuthenticated = false, IsValid = true, Data = "Request A" },
    new Request { IsAuthenticated = true, IsValid = false, Data = "Request B" },
    new Request { IsAuthenticated = true, IsValid = true, Data = "Request C" }
};

foreach (var r in requests)
{
    Console.WriteLine("--- New Request ---");
    var handled = auth.Handle(r);
    Console.WriteLine(handled ? "Request was handled by the chain." : "Request was not handled.");
}

// Pattern info:
// Pattern: Chain of Responsibility
// Intent: Pass a request along a chain of handlers; each handler may handle or pass it on.
// Pattern locations (this file):
// - Request model: lines 4-9
// - Handler base class: lines 12-23
// - AuthHandler: lines 25-37
// - ValidationHandler: lines 39-51
// - ProcessingHandler: lines 53-60
// - Chain assembly (building chain): lines 62-64
// - Demo loop (sending requests into the chain): lines 73-77

namespace Patterns.ChainOfResponsibility.Models;

public class Request
{
    public bool IsAuthenticated { get; set; }
    public bool IsValid { get; set; }
    public string Data { get; set; } = string.Empty;
}

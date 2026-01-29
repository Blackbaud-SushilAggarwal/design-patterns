# Chain of Responsibility Pattern

Intent: Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.

This demo builds a chain of handlers: `AuthHandler` -> `ValidationHandler` -> `ProcessingHandler`.

- `AuthHandler`: stops the chain if authentication fails.
- `ValidationHandler`: stops the chain if validation fails.
- `ProcessingHandler`: performs the final processing.

Run:

```powershell
dotnet run --project Patterns/ChainOfResponsibility/ChainOfResponsibility.csproj
```

**Pattern mapping (this demo file):**

- `Request` model: [Patterns/ChainOfResponsibility/Program.cs](Patterns/ChainOfResponsibility/Program.cs#L4-L9)
- `Handler` base class: [Patterns/ChainOfResponsibility/Program.cs](Patterns/ChainOfResponsibility/Program.cs#L12-L23)
- `AuthHandler`: [Patterns/ChainOfResponsibility/Program.cs](Patterns/ChainOfResponsibility/Program.cs#L25-L37)
- `ValidationHandler`: [Patterns/ChainOfResponsibility/Program.cs](Patterns/ChainOfResponsibility/Program.cs#L39-L51)
- `ProcessingHandler`: [Patterns/ChainOfResponsibility/Program.cs](Patterns/ChainOfResponsibility/Program.cs#L53-L60)
- Chain assembly / demo: [Patterns/ChainOfResponsibility/Program.cs](Patterns/ChainOfResponsibility/Program.cs#L62-L77)

# Interpreter Pattern

Simple Interpreter pattern demo that builds and evaluates small arithmetic expression trees.

Mapping to GoF:
- `IExpression` : Abstract expression interface.
- `NumberExpression`, `AddExpression`, `SubtractExpression` : Concrete expression nodes.

Examples in `Program.cs` evaluate expressions such as `(5 + 3) - 2` and `10 - (4 + 1)`.

Run:

```powershell
dotnet run --project Patterns/Interpreter/Interpreter.csproj
```

**Pattern mapping (this demo file):**

- `IExpression` interface: [Patterns/Interpreter/Program.cs](Patterns/Interpreter/Program.cs#L6-L6)
- `NumberExpression` (leaf): [Patterns/Interpreter/Program.cs](Patterns/Interpreter/Program.cs#L11-L16)
- `AddExpression` (binary +): [Patterns/Interpreter/Program.cs](Patterns/Interpreter/Program.cs#L21-L27)
- `SubtractExpression` (binary -): [Patterns/Interpreter/Program.cs](Patterns/Interpreter/Program.cs#L32-L38)
- Demo construction & evaluation: [Patterns/Interpreter/Program.cs](Patterns/Interpreter/Program.cs#L40-L57)

# Abstract Factory Pattern

Intent: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

How this demo maps to the pattern:
- `IGuiFactory` : Abstract factory (declares creation methods).
- `WinFactory` / `MacFactory` : Concrete factories producing a family of products.
- Products: `IStudentRepository` implementations (`WinRepo`, `MacRepo`) and `ILogger` implementations (`WinLogger`, `MacLogger`).

Why it helps:
- Lets you change entire product families (repo + logger) together and ensures product compatibility.

Run:
```bash
dotnet run --project Patterns/AbstractFactory
```

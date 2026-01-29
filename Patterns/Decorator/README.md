# Decorator Pattern

Intent: Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending behavior.

How this demo maps to the pattern:
- `IStudentPrinter` : Component interface.
- `BasicPrinter` : Concrete component providing core behavior.
- `PrinterDecorator` : Abstract decorator holding a reference to an `IStudentPrinter` and delegating calls.
- `TimestampDecorator`, `UppercaseDecorator` : Concrete decorators that add behavior before/after delegating to the inner component.

Run:
```bash
dotnet run --project Patterns/Decorator
```

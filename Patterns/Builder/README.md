# Builder Pattern

Intent: Separate the construction of a complex object from its representation so the same construction process can create different representations.

How this demo maps to the pattern:
- `StudentBuilder` : Builder (provides fluent methods `SetName`, `SetAge`, `SetEmail` and `Build`).
- `Student` : Product constructed by the builder.

Why it helps:
- Makes creating configured `Student` objects readable and flexible, especially when many optional properties exist.

Run:
```bash
dotnet run --project Patterns/Builder
```

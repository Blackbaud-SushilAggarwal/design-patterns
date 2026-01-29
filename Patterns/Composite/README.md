# Composite Pattern

Intent: Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions uniformly.

How this demo maps to the pattern:
- `IComponent` : Component interface declaring `Display`.
- `StudentLeaf` : Leaf representing an individual student.
- `Group` : Composite that contains children implementing `IComponent` and forwards `Display` to them.

Why it helps:
- Clients can work with `IComponent` without worrying whether they're dealing with a leaf or a composite, simplifying client code.

Run:
```bash
dotnet run --project Patterns/Composite
```

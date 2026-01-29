# Flyweight Pattern

Intent: Use sharing to support large numbers of fine-grained objects efficiently by separating intrinsic (shared) state from extrinsic (unique) state.

How this demo maps to the pattern:
- `StudentStyle` : Flyweight (intrinsic state — e.g., color) shared across many `Student` objects.
- `StudentStyleFactory` : Flyweight factory that provides shared `StudentStyle` instances from a cache.
- `Student` : Client object that holds a reference to a `StudentStyle` (shared) and its own unique data (name).

Why it helps:
- Reduces memory by reusing common state rather than duplicating it for each object.

Run:
```bash
dotnet run --project Patterns/Flyweight
```

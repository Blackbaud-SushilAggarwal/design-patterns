# Simple Factory Pattern

Intent: Encapsulate object creation in a single place (a simple factory) to centralize logic for creating related objects.

How this demo maps to the pattern:
- `StudentFactory` : Simple factory with a `Create(StudentType)` method.
- `StudentType` : enum used to choose the concrete product.
- Products: `ScienceStudent`, `ArtsStudent`.

Why it helps:
- Avoids scattering construction logic (strings/switches) across the codebase and replaces it with a single, type-safe factory method.

Run:
```bash
dotnet run --project Patterns/Factory
```

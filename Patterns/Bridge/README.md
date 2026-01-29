# Bridge Pattern

Intent: Decouple an abstraction from its implementation so the two can vary independently.

How this demo maps to the pattern:
- `Report` (in code: `Report`/`StudentReport`) : Abstraction (high-level control).
- `IRenderer` : Implementor (defines low-level rendering operations).
- `PlainRenderer`, `HtmlRenderer` : Concrete implementors providing rendering strategies.

Why it helps:
- You can add new report types and new renderers independently without combinatorial class growth.

Run:
```bash
dotnet run --project Patterns/Bridge
```

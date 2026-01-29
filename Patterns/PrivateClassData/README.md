# Private Class Data

Intent: Encapsulate a set of related fields in a private inner class to control access, centralize validation, and provide a stable interface while allowing internal changes.

How to read the demo:
- The demo shows a public-facing class that delegates storage and mutation to a private inner data class. The outer class exposes methods/properties that enforce validation or invariants before delegating to the private data object.

Why it helps:
- Keeps internal representation private and focused, reducing the chance of inconsistent state and making future refactors easier.

Run:
```bash
dotnet run --project Patterns/PrivateClassData
```

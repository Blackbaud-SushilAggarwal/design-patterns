# Memento Pattern

Simple Memento demo using a `Document` originator and a history list as the caretaker.

Run:

```powershell
dotnet run --project Patterns/Memento/Memento.csproj
```

Mapping to GoF (see `Program.cs`):
- `Document`: Originator; `CreateMemento()` and `Restore()` implement saving/restoring state.
- `Memento` (private record inside `Document`): stores state snapshot.
- Caretaker: `history` list in demo stores mementos.

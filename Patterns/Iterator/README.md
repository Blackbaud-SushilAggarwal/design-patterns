# Iterator Pattern

Simple Iterator demo implementing `IEnumerable<int>` and a custom `IEnumerator<int>`.

Run:

```powershell
dotnet run --project Patterns/Iterator/Iterator.csproj
```

Mapping to GoF (see `Program.cs`):
- `NumberCollection`: Aggregate exposing an iterator.
- `NumberEnumerator`: Iterator implementation.

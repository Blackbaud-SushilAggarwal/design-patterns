# Strategy Pattern

Simple Strategy pattern demo using a `Calculator` context and interchangeable arithmetic strategies.

Run:

```powershell
dotnet run --project Patterns/Strategy/Strategy.csproj
```

Mapping to GoF (see `Program.cs`):
- `IStrategy` interface and concrete strategies: `AddStrategy`, `MultiplyStrategy`, `SubtractStrategy`.
- `Calculator`: Context that delegates work to the configured strategy.

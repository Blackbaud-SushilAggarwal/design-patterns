# State Pattern

Simple State pattern demo using a `LightSwitch` context and `OnState`/`OffState` concrete states.

Run:

```powershell
dotnet run --project Patterns/State/State.csproj
```

Mapping to GoF (see `Program.cs`):
- `IState` interface and concrete states: `OnState`, `OffState`.
- `LightSwitch`: Context that holds and delegates to current state.

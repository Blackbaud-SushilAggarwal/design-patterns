# Observer Pattern

Simple Observer demo using a `WeatherStation` subject and `CurrentConditionsDisplay` observers.

Run:

```powershell
dotnet run --project Patterns/Observer/Observer.csproj
```

Mapping to GoF (see `Program.cs`):
- `WeatherStation`: Subject with `Attach`/`Detach`/`Notify`.
- `IObserver` / `CurrentConditionsDisplay`: Observers updated on state changes.

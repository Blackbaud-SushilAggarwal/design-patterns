# Template Method Pattern

Simple Template Method demo using `DataProcessor` with `CsvProcessor` and `JsonProcessor`.

Run:

```powershell
dotnet run --project Patterns/TemplateMethod/TemplateMethod.csproj
```

Mapping to GoF (see `Program.cs`):
- `DataProcessor` defines the template method `Process()`.
- `CsvProcessor`, `JsonProcessor` override primitive operations.

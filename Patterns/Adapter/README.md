# Adapter Pattern

Intent: Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

How this demo maps to the pattern:
- `Adaptee` : Existing class with `PrintDetails(string,int)`.
- `IStudentPrinter` : Target interface expected by clients.
- `StudentPrinterAdapter` : Adapter class that holds an `Adaptee` and implements `IStudentPrinter`, delegating calls to the adaptee after adapting parameters.

Run:
```bash
dotnet run --project Patterns/Adapter
```

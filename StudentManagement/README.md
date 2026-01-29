# Student Management + Gang of Four Patterns

This workspace contains a minimal Student Management .NET 9 API and separate folders demonstrating Gang of Four creational patterns. Each pattern folder is self-contained (has its own `.csproj`, `Program.cs`, and README) so you can study them independently.

Structure:

- `StudentManagement/StudentApi` - Minimal Web API (net9.0) exposing student endpoints.
- `Patterns/Singleton` - Singleton example (Logger).
- `Patterns/FactoryMethod` - Factory Method example (repository creators).
- `Patterns/AbstractFactory` - Abstract Factory example (repository families).
- `Patterns/Builder` - Builder example (StudentBuilder).
- `Patterns/Prototype` - Prototype example (Student cloning).

Run the API:

```bash
dotnet run --project StudentManagement/StudentApi
```

Run any pattern demo, for example:

```bash
dotnet run --project Patterns/Singleton
```

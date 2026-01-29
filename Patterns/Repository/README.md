# Repository Pattern

This small demo shows a simple generic `IRepository<T>` and an `InMemoryRepository<T>` implementation.

Run the project:

```powershell
dotnet run --project Patterns/Repository/Repository.csproj
```

The `Program.cs` demonstrates adding, updating and removing `Person` entities.

**Pattern mapping (this demo file):**

- `IEntity` marker: [Patterns/Repository/Program.cs](Patterns/Repository/Program.cs#L6-L7)
- `IRepository<T>`: [Patterns/Repository/Program.cs](Patterns/Repository/Program.cs#L9-L17)
- `Person` model: [Patterns/Repository/Program.cs](Patterns/Repository/Program.cs#L20-L25)
- `InMemoryRepository<T>` implementation: [Patterns/Repository/Program.cs](Patterns/Repository/Program.cs#L28-L54)
- Demo usage (add/update/remove): [Patterns/Repository/Program.cs](Patterns/Repository/Program.cs#L56-L79)

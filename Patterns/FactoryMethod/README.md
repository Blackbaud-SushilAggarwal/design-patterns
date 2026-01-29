# Factory Method Pattern

Intent: Define an interface for creating an object, letting subclasses decide which class to instantiate.

How this demo maps to the pattern:
- `RepositoryCreator` : Creator (declares `FactoryMethod`).
- `InMemoryCreator` / `ConcreteCreator` : Concrete creators implementing `FactoryMethod` to return concrete repositories.
- `IStudentRepository` and `InMemoryRepository` : Products returned by the factory method.

Why it helps:
- Encapsulates object creation in subclasses, enabling easy substitution of repository implementations without changing client code.

Run:
```bash
dotnet run --project Patterns/FactoryMethod
```

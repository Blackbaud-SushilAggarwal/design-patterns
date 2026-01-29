# Singleton Pattern

Intent: Ensure a class has only one instance and provide a global point of access.

How this demo maps to the pattern:
- `Logger` : Singleton (single shared instance). Implementation uses double-check locking with a `volatile` field and a `lock` object.

Why it works:
- Private constructor prevents external instantiation. The `Instance` property lazily creates the single instance and uses locking to ensure thread-safety.

Run:
```bash
dotnet run --project Patterns/Singleton
```


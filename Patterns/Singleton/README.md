# Singleton Pattern

This folder demonstrates the Singleton pattern with a thread-safe `Logger`.

Run:

```bash
dotnet run --project Patterns/Singleton
```

Key points:
- Use `Lazy<T>` to create a thread-safe single instance.
- Constructor is private to prevent external instantiation.

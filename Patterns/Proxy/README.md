# Proxy Pattern

Intent: Provide a surrogate or placeholder for another object to control access to it.

How this demo maps to the pattern:
- `IStudentService` : Subject interface.
- `RealStudentService` : Real subject that performs the actual work.
- `StudentServiceProxy` : Proxy that controls access (e.g., permission check, lazy initialization) to the real subject.

Why it helps:
- Lets you add access control, lazy instantiation, logging, or caching without changing the real subject.

Run:
```bash
dotnet run --project Patterns/Proxy
```

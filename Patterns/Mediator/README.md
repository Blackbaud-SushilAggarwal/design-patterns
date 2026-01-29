# Mediator Pattern

Simple Mediator demo using a `ChatRoom` mediator and `ChatUser` colleagues.

Run:

```powershell
dotnet run --project Patterns/Mediator/Mediator.csproj
```

Mapping to GoF (see `Program.cs`):
- `ChatRoom`: Mediator that coordinates message delivery.
- `ChatUser`: Colleague that sends/receives messages via the mediator.

# Command Pattern

Simple Command pattern demo using a `RemoteControl` invoker and `Light` receiver.

Run:

```powershell
dotnet run --project Patterns/Command/Command.csproj
```

Mapping to GoF:
- `ICommand` : Command interface
- `LightOnCommand`, `LightOffCommand` : Concrete commands
- `Light` : Receiver
- `RemoteControl` : Invoker (stores and executes commands, supports undo)

**Pattern mapping (this demo file):**

- `ICommand` interface: [Patterns/Command/Program.cs](Patterns/Command/Program.cs#L10-L14)
- `Light` (receiver): [Patterns/Command/Program.cs](Patterns/Command/Program.cs#L16-L31)
- `LightOnCommand`: [Patterns/Command/Program.cs](Patterns/Command/Program.cs#L33-L39)
- `LightOffCommand`: [Patterns/Command/Program.cs](Patterns/Command/Program.cs#L41-L47)
- `RemoteControl` (invoker): [Patterns/Command/Program.cs](Patterns/Command/Program.cs#L49-L68)
- Demo usage: [Patterns/Command/Program.cs](Patterns/Command/Program.cs#L70-L93)

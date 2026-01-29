# Prototype Pattern

Intent: Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

How this demo maps to the pattern:
- `Student` : Prototype (implements `ICloneable`).
- `Address` : Child object demonstrating the need for deep cloning when a prototype has references to other objects.

What the code shows:
- `Student.ShallowClone()` uses `MemberwiseClone` — child `Address` is shared between original and clone (modifying one affects the other).
- `Student.Clone()` performs a deep clone by cloning the `Address` as well, preventing shared-state side effects.

Run:
```bash
dotnet run --project Patterns/Prototype
```


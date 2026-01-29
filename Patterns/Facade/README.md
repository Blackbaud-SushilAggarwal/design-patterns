# Facade Pattern

Intent: Provide a unified, higher-level interface that makes a subsystem easier to use.

How this demo maps to the pattern:
- `Registrar`, `Billing`, `Notification` : Subsystem classes that perform detailed work.
- `EnrollmentFacade` : Facade that exposes a single `Enroll` method and orchestrates calls to the subsystems.

Why it helps:
- Simplifies usage for clients by hiding complex interactions between multiple subsystem classes behind a single entry point.

Run:
```bash
dotnet run --project Patterns/Facade
```

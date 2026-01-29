using System;

// State pattern demo consolidated into Program.cs
// GoF roles:
// - State: `IState` and concrete states (`OnState`, `OffState`)
// - Context: `LightSwitch` which maintains current state and delegates behavior

public interface IState
{
    void Handle(LightSwitch context);
}

public class OffState : IState
{
    public void Handle(LightSwitch context)
    {
        Console.WriteLine("OffState: Turning light ON and switching to OnState.");
        context.SetState(new OnState());
    }
}

public class OnState : IState
{
    public void Handle(LightSwitch context)
    {
        Console.WriteLine("OnState: Turning light OFF and switching to OffState.");
        context.SetState(new OffState());
    }
}

public class LightSwitch
{
    private IState _state;
    public LightSwitch() => _state = new OffState();
    public void SetState(IState state) => _state = state;
    public void Press()
    {
        Console.WriteLine("LightSwitch: Pressed the switch.");
        _state.Handle(this);
    }
}

// Demo
var lightSwitch = new LightSwitch();
Console.WriteLine("Pressing switch 3 times to demo state transitions:");
lightSwitch.Press();
lightSwitch.Press();
lightSwitch.Press();

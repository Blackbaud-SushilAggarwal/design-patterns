using System;

// Simple Command pattern demo consolidated into Program.cs
// GoF roles:
// - Command: `ICommand`
// - ConcreteCommand: `LightOnCommand`, `LightOffCommand`
// - Receiver: `Light`
// - Invoker: `RemoteControl`

public interface ICommand
{
    void Execute();
    void Undo();
}

public class Light
{
    public string Location { get; }
    private bool _isOn;
    public Light(string location) => Location = location;
    public void On()
    {
        _isOn = true;
        Console.WriteLine($"{Location} light is ON");
    }
    public void Off()
    {
        _isOn = false;
        Console.WriteLine($"{Location} light is OFF");
    }
}

public class LightOnCommand : ICommand
{
    private readonly Light _light;
    public LightOnCommand(Light light) => _light = light;
    public void Execute() => _light.On();
    public void Undo() => _light.Off();
}

public class LightOffCommand : ICommand
{
    private readonly Light _light;
    public LightOffCommand(Light light) => _light = light;
    public void Execute() => _light.Off();
    public void Undo() => _light.On();
}

public class RemoteControl
{
    private ICommand? _current;
    private ICommand? _lastExecuted;

    public void SetCommand(ICommand command) => _current = command;

    public void PressButton()
    {
        if (_current == null) { Console.WriteLine("No command set"); return; }
        _current.Execute();
        _lastExecuted = _current;
    }

    public void PressUndo()
    {
        if (_lastExecuted == null) { Console.WriteLine("Nothing to undo"); return; }
        _lastExecuted.Undo();
    }
}

// Demo
var livingRoomLight = new Light("Living Room");
var kitchenLight = new Light("Kitchen");

var livingOn = new LightOnCommand(livingRoomLight);
var livingOff = new LightOffCommand(livingRoomLight);
var kitchenOn = new LightOnCommand(kitchenLight);

var remote = new RemoteControl();

Console.WriteLine("-- Remote: turn on living room light --");
remote.SetCommand(livingOn);
remote.PressButton();

Console.WriteLine("-- Remote: turn off living room light --");
remote.SetCommand(livingOff);
remote.PressButton();

Console.WriteLine("-- Remote: undo last command (should turn living room back on) --");
remote.PressUndo();

Console.WriteLine("-- Remote: turn on kitchen light --");
remote.SetCommand(kitchenOn);
remote.PressButton();

// Pattern info:
// Pattern: Command
// Intent:  encapsulates a request as an object, decoupling the sender from the receiver. 
// It allows requests to be queued, logged, parameterized, or undone/redone, providing flexibility and extensibility in executing operations.
// Pattern locations (this file):
// - `ICommand` interface: lines 10-14
// - `Light` (receiver): lines 16-31
// - `LightOnCommand`: lines 33-39
// - `LightOffCommand`: lines 41-47
// - `RemoteControl` (invoker): lines 49-68
// - Demo usage (creating commands and invoking): lines 70-93

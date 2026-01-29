using System;
using System.Collections.Generic;

// Observer pattern demo consolidated into Program.cs
// GoF roles:
// - Subject: WeatherStation
// - Observer: IObserver / DisplayElement

public interface IObserver
{
    void Update(int temperature);
}

public class WeatherStation
{
    private readonly List<IObserver> _observers = new();
    private int _temperature;

    public void Attach(IObserver o) => _observers.Add(o);
    public void Detach(IObserver o) => _observers.Remove(o);
    public void SetTemperature(int t)
    {
        _temperature = t;
        Notify();
    }
    private void Notify() { foreach (var o in _observers) o.Update(_temperature); }
}

public class CurrentConditionsDisplay : IObserver
{
    private readonly string _name;
    public CurrentConditionsDisplay(string name) => _name = name;
    public void Update(int temperature) => Console.WriteLine($"{_name} display: Current temperature = {temperature}°C");
}

// Demo
var station = new WeatherStation();
var displayA = new CurrentConditionsDisplay("Lobby");
var displayB = new CurrentConditionsDisplay("Office");
station.Attach(displayA);
station.Attach(displayB);

Console.WriteLine("Setting temperature to 25");
station.SetTemperature(25);

Console.WriteLine("Detaching Office display and setting to 28");
station.Detach(displayB);
station.SetTemperature(28);

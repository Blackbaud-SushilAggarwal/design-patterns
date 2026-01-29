using System;

// Strategy pattern demo consolidated into Program.cs
// GoF roles:
// - Strategy: `IStrategy` and concrete strategies (`AddStrategy`, `MultiplyStrategy`)
// - Context: `Calculator` that uses a strategy to perform an operation

public interface IStrategy
{
    int Execute(int a, int b);
}

public class AddStrategy : IStrategy { public int Execute(int a, int b) => a + b; }
public class MultiplyStrategy : IStrategy { public int Execute(int a, int b) => a * b; }
public class SubtractStrategy : IStrategy { public int Execute(int a, int b) => a - b; }

public class Calculator
{
    private IStrategy _strategy;
    public Calculator(IStrategy strategy) => _strategy = strategy;
    public void SetStrategy(IStrategy strategy) => _strategy = strategy;
    public int Execute(int a, int b) => _strategy.Execute(a, b);
}

// Demo
var calc = new Calculator(new AddStrategy());
Console.WriteLine("5 + 3 = " + calc.Execute(5, 3));

calc.SetStrategy(new MultiplyStrategy());
Console.WriteLine("5 * 3 = " + calc.Execute(5, 3));

calc.SetStrategy(new SubtractStrategy());
Console.WriteLine("5 - 3 = " + calc.Execute(5, 3));

// Interpreter pattern demo consolidated into Program.cs

/// <summary>
/// Represents a node in an expression tree used by the Interpreter pattern.
/// </summary>
public interface IExpression { int Interpret(); }

/// <summary>
/// Leaf expression that holds a single integer value.
/// </summary>
public class NumberExpression : IExpression
{
    private readonly int _value;
    public NumberExpression(int value) => _value = value;
    public int Interpret() => _value;
}

/// <summary>
/// Binary expression that represents addition of two sub-expressions.
/// </summary>
public class AddExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;
    public AddExpression(IExpression left, IExpression right) { _left = left; _right = right; }
    public int Interpret() => _left.Interpret() + _right.Interpret();
}

/// <summary>
/// Binary expression that represents subtraction of two sub-expressions.
/// </summary>
public class SubtractExpression : IExpression
{
    private readonly IExpression _left;
    private readonly IExpression _right;
    public SubtractExpression(IExpression left, IExpression right) { _left = left; _right = right; }
    public int Interpret() => _left.Interpret() - _right.Interpret();
}

// Build an expression tree and evaluate it. The tree below represents the arithmetic
// expression: (5 + 3) - 2

IExpression expression = new SubtractExpression(
    new AddExpression(new NumberExpression(5), new NumberExpression(3)),
    new NumberExpression(2)
);

Console.WriteLine("Expression: (5 + 3) - 2");
Console.WriteLine("Result: " + expression.Interpret());

// Additional example: 10 - (4 + 1)
IExpression expr2 = new SubtractExpression(
    new NumberExpression(10),
    new AddExpression(new NumberExpression(4), new NumberExpression(1))
);
Console.WriteLine("Expression: 10 - (4 + 1)");
Console.WriteLine("Result: " + expr2.Interpret());

// Pattern info:
// Pattern: Interpreter
// Intent: Define a representation for a grammar and an interpreter that uses the representation to interpret sentences in the language.
// Pattern locations (this file):
// - `IExpression` interface: line 6
// - `NumberExpression` (leaf): lines 11-16
// - `AddExpression` (binary +): lines 21-27
// - `SubtractExpression` (binary -): lines 32-38
// - Demo expression construction and evaluation: lines 40-57

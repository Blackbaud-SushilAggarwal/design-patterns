using System;
using System.Collections;
using System.Collections.Generic;

// Iterator pattern demo consolidated into Program.cs
// GoF roles:
// - Aggregate: NumberCollection
// - Iterator: NumberEnumerator

public class NumberCollection : IEnumerable<int>
{
    private readonly int[] _items;
    public NumberCollection(int[] items) => _items = items;
    public IEnumerator<int> GetEnumerator() => new NumberEnumerator(_items);
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class NumberEnumerator : IEnumerator<int>
{
    private readonly int[] _items;
    private int _position = -1;
    public NumberEnumerator(int[] items) => _items = items;
    public int Current => _items[_position];
    object IEnumerator.Current => Current;
    public bool MoveNext() { _position++; return _position < _items.Length; }
    public void Reset() => _position = -1;
    public void Dispose() { }
}

// Demo
var nums = new NumberCollection(new[] { 1, 2, 3, 5, 8 });
Console.WriteLine("Iterating numbers:");
foreach (var n in nums) Console.WriteLine(n);

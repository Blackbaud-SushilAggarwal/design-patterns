using System;
using System.Collections.Generic;

// Memento: capture and externalize an object's internal state without violating encapsulation.
// This file shows a minimal, correct implementation where the Originator owns a private Memento.

// GoF roles:
// - Originator: `Document` — creates and restores mementos.
// - Memento: private record `Memento` inside `Document` — holds the snapshot.
// - Caretaker: the `history` list in the demo — stores opaque mementos returned by the Originator.

public class Document
{
    // Originator state
    public string Content { get; private set; } = string.Empty;

    // Modify state
    public void Write(string text) => Content += text;

    // CreateMemento: captures current internal state and returns an opaque memento object
    public object CreateMemento() => new Memento(Content);

    // Restore: accepts a memento produced by this originator and restores internal state.
    public void Restore(object m)
    {
        if (m is Memento mem)
            Content = mem.State;
    }

    // Private memento type — inaccessible to external callers, preserving encapsulation.
    private readonly record struct Memento(string State);
}

// Demo (Caretaker role):
var doc = new Document();
var history = new List<object>();

doc.Write("Version1. ");
// Save snapshot 1
history.Add(doc.CreateMemento());

doc.Write("Version2. ");
// Save snapshot 2
history.Add(doc.CreateMemento());

doc.Write("CurrentVersion. ");
Console.WriteLine("Before restore: " + doc.Content);

// Restore to previous (caretaker passes back the opaque memento to the originator)
doc.Restore(history[1]);
Console.WriteLine("After restore to Version2: " + doc.Content);

doc.Restore(history[0]);
Console.WriteLine("After restore to Version1: " + doc.Content);

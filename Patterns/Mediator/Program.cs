using System;
using System.Collections.Generic;

// Mediator pattern demo consolidated into Program.cs
// GoF roles:
// - Mediator: ChatRoom
// - Colleague: ChatUser

public class ChatRoom
{
    private readonly List<ChatUser> _users = new();
    public void Register(ChatUser user) { _users.Add(user); user.Room = this; }
    public void Send(string from, string message)
    {
        foreach (var u in _users)
            if (u.Name != from) u.Receive(from, message);
    }
}

public class ChatUser
{
    public string Name { get; }
    public ChatRoom? Room { get; set; }
    public ChatUser(string name) => Name = name;
    public void Send(string message) => Room?.Send(Name, message);
    public void Receive(string from, string message) => Console.WriteLine($"{Name} received from {from}: {message}");
}

// Demo
var room = new ChatRoom();
var alice = new ChatUser("Alice");
var bob = new ChatUser("Bob");
var carol = new ChatUser("Carol");

room.Register(alice);
room.Register(bob);
room.Register(carol);

alice.Send("Hello everyone!");
bob.Send("Hi Alice!");

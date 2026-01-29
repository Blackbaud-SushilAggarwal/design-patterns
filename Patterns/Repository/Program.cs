using System.Collections.Concurrent;
using System.Collections.Generic;

// Repository pattern demo consolidated into Program.cs

// IEntity marker
public interface IEntity { int Id { get; set; } }

// Generic repository interface
public interface IRepository<T> where T : IEntity
{
	T Add(T item);
	T? Get(int id);
	IEnumerable<T> GetAll();
	bool Update(T item);
	bool Remove(int id);
}

// Simple model
public class Person : IEntity
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public override string ToString() => $"Person {{ Id = {Id}, Name = {Name} }}";
}

// Thread-safe in-memory repository
public class InMemoryRepository<T> : IRepository<T> where T : IEntity
{
	private readonly ConcurrentDictionary<int, T> _store = new();

	public T Add(T item)
	{
		_store[item.Id] = item;
		return item;
	}

	public T? Get(int id)
	{
		_store.TryGetValue(id, out var item);
		return item;
	}

	public IEnumerable<T> GetAll() => _store.Values;

	public bool Update(T item)
	{
		if (!_store.ContainsKey(item.Id)) return false;
		_store[item.Id] = item;
		return true;
	}

	public bool Remove(int id) => _store.TryRemove(id, out _);
}

// Demo
var repo = new InMemoryRepository<Person>();

var alice = new Person { Id = 1, Name = "Alice" };
var bob = new Person { Id = 2, Name = "Bob" };

repo.Add(alice);
repo.Add(bob);

Console.WriteLine("All people after add:");
foreach (var p in repo.GetAll()) Console.WriteLine(p);

// Update Bob
bob.Name = "Robert";
repo.Update(bob);

Console.WriteLine("\nAfter update:");
Console.WriteLine(repo.Get(2));

// Remove Alice
repo.Remove(1);

Console.WriteLine("\nAfter remove:");
foreach (var p in repo.GetAll()) Console.WriteLine(p);

// Pattern info:
// Pattern: Repository
// Intent: Provide a collection-like interface for accessing domain objects without exposing persistence details.
// Pattern locations (this file):
// - `IEntity` marker: lines 6-7
// - `IRepository<T>` interface: lines 9-17
// - `Person` model: lines 20-25
// - `InMemoryRepository<T>` implementation: lines 28-54
// - Demo usage (add/update/remove): lines 56-79

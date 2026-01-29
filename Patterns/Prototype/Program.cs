using System;

// Prototype pattern: allow cloning of Student objects to create new instances by copying state.

namespace PrototypeDemo
{
    class Student : ICloneable
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;

        public object Clone()
        {
            // Shallow copy is sufficient for primitive/string properties; adjust for deep copy if needed
            return new Student { Id = this.Id, Name = this.Name, Age = this.Age, Email = this.Email };
        }

        public override string ToString() => $"{Id} - {Name} ({Age}) - {Email}";
    }

    class Program
    {
        static void Main()
        {
            var original = new Student { Name = "Dana", Age = 22, Email = "dana@example.com" };
            var clone = (Student)original.Clone();
            clone.Id = Guid.NewGuid();
            clone.Name += " (Clone)";

            Console.WriteLine(original);
            Console.WriteLine(clone);
        }
    }
}

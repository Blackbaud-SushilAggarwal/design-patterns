using System;

namespace PrototypeExample
{
    class Address : ICloneable
    {
        public string Street { get; set; }
        public Address(string street) { Street = street; }
        public object Clone() => new Address(Street);
        public override string ToString() => Street;
    }

    class Person : ICloneable
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Person(string name, Address address) { Name = name; Address = address; }
        public object Clone() => new Person(Name, (Address)Address.Clone());
        public override string ToString() => $"{Name}, {Address}";
    }

    class Program
    {
        static void Main()
        {
            var p1 = new Person("Alice", new Address("1 Main St"));
            var p2 = (Person)p1.Clone();
            p2.Name = "Bob";
            p2.Address.Street = "2 Side St";

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}

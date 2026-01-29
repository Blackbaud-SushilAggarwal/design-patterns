using System;

// Adapter pattern: adapt an existing Adaptee to the IStudentPrinter interface.
// Convert the interface of a class (Adaptee) into another interface that the client (IStudentPrinter) expects.
// client (IStudentPrinter) wants Student class but we have Adaptee that works with name and age separately.
// In object adapter pattern, adapter holds an instance of the adaptee and delegates calls to it. [Composition based.]
//in calss adapter we use inheritance (instead of composition) to adapt the adaptee to the target interface.

namespace AdapterPatternDemo
{
    class Adaptee
    {
        public void PrintDetails(string name, int age) => Console.WriteLine($"Adaptee prints: {name} ({age})");
    }

    interface IStudentPrinter { void Print(Student s); }

    class Student { public string Name { get; set; } = ""; public int Age { get; set; } }

    // Adapter wraps Adaptee and exposes IStudentPrinter
    // StudentPrinterAdapter is the adapter class
    class StudentPrinterAdapter : IStudentPrinter
    {
        private readonly Adaptee _adaptee = new();
        public void Print(Student s) => _adaptee.PrintDetails(s.Name, s.Age);
    }

    class Program
    {
        static void Main()
        {
            var student = new Student { Name = "Eve", Age = 21 };
            IStudentPrinter printer = new StudentPrinterAdapter();
            printer.Print(student);
        }
    }
}

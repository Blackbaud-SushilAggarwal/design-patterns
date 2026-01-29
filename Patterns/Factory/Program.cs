using System;

// Simple Factory pattern: a single Factory class decides which concrete Student to create.

namespace FactoryPatternDemo
{
    abstract class Student { public abstract string Describe(); }
    class ScienceStudent : Student { public override string Describe() => "Science Student"; }
    class ArtsStudent : Student { public override string Describe() => "Arts Student"; }

    // Use an enum to select the student type safely instead of passing strings.
    enum StudentType { Science, Arts }

    static class StudentFactory
    {
        public static Student Create(StudentType type) => type switch
        {
            StudentType.Science => new ScienceStudent(),
            StudentType.Arts => new ArtsStudent(),
            _ => throw new ArgumentException("Unknown student type")
        };
    }

    class Program
    {
        static void Main()
        {
            var s1 = StudentFactory.Create(StudentType.Science);
            var s2 = StudentFactory.Create(StudentType.Arts);
            Console.WriteLine(s1.Describe());
            Console.WriteLine(s2.Describe());
        }
    }
}

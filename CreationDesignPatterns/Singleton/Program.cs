using System;

namespace SingletonExample
{
    class Singleton
    {
        private static readonly Lazy<Singleton> _lazy = new(() => new Singleton());
        public static Singleton Instance => _lazy.Value;
        private Singleton() { }
        public void DoWork() => Console.WriteLine($"Singleton instance hash: {GetHashCode()}");
    }

    class Program
    {
        static void Main()
        {
            var s1 = Singleton.Instance;
            var s2 = Singleton.Instance;
            s1.DoWork();
            Console.WriteLine($"Same instance? {ReferenceEquals(s1, s2)}");
        }
    }
}

using System;

namespace BuilderExample
{
    class Product
    {
        public string Parts { get; set; } = string.Empty;
        public void Show() => Console.WriteLine($"Product parts: {Parts}");
    }

    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    class ConcreteBuilder : IBuilder
    {
        private Product _product = new();
        public void BuildPartA() => _product.Parts += "PartA ";
        public void BuildPartB() => _product.Parts += "PartB ";
        public Product GetResult()
        {
            var result = _product;
            _product = new();
            return result;
        }
    }

    class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }

    class Program
    {
        static void Main()
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Construct(builder);
            var product = builder.GetResult();
            product.Show();
        }
    }
}

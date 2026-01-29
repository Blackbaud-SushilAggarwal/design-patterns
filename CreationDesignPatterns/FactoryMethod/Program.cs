using System;

namespace FactoryMethodExample
{
    interface IProduct { string Operation(); }

    class ProductA : IProduct { public string Operation() => "ProductA"; }
    class ProductB : IProduct { public string Operation() => "ProductB"; }

    abstract class Creator
    {
        public abstract IProduct FactoryMethod();
        public void AnOperation()
        {
            var product = FactoryMethod();
            Console.WriteLine($"Creator used product: {product.Operation()}");
        }
    }

    class ConcreteCreatorA : Creator { public override IProduct FactoryMethod() => new ProductA(); }
    class ConcreteCreatorB : Creator { public override IProduct FactoryMethod() => new ProductB(); }

    class Program
    {
        static void Main()
        {
            Creator c1 = new ConcreteCreatorA();
            Creator c2 = new ConcreteCreatorB();
            c1.AnOperation();
            c2.AnOperation();
        }
    }
}

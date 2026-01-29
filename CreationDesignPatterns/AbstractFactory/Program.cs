using System;

namespace AbstractFactoryExample
{
    interface IButton { void Paint(); }
    interface ICheckbox { void Paint(); }

    class WinButton : IButton { public void Paint() => Console.WriteLine("Windows Button"); }
    class MacButton : IButton { public void Paint() => Console.WriteLine("Mac Button"); }
    class WinCheckbox : ICheckbox { public void Paint() => Console.WriteLine("Windows Checkbox"); }
    class MacCheckbox : ICheckbox { public void Paint() => Console.WriteLine("Mac Checkbox"); }

    interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }

    class WinFactory : IGUIFactory
    {
        public IButton CreateButton() => new WinButton();
        public ICheckbox CreateCheckbox() => new WinCheckbox();
    }

    class MacFactory : IGUIFactory
    {
        public IButton CreateButton() => new MacButton();
        public ICheckbox CreateCheckbox() => new MacCheckbox();
    }

    class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;
        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();
            _checkbox = factory.CreateCheckbox();
        }
        public void Paint() { _button.Paint(); _checkbox.Paint(); }
    }

    class Program
    {
        static void Main()
        {
            IGUIFactory factory = new WinFactory();
            var app = new Application(factory);
            app.Paint();

            factory = new MacFactory();
            app = new Application(factory);
            app.Paint();
        }
    }
}

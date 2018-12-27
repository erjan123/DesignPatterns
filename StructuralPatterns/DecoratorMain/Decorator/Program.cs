using Decorator.DecoratorOrginalPattern.ConcreteClasses;
using Decorator.DecoratorOrginalPattern.Interfaces;
using System;

namespace Decorator
{
    class Program
    {
        static void Display(string str, IComponent component)
        {
            Console.WriteLine(str + component.Operation());
        }

        static void Main(string[] args)
        {
            #region O'Reilly C# Design Pattern - Decorator Example

                Console.WriteLine("Decorator Pattern\n");

                IComponent component = new Component();
                Display("1. Basic component: ", component);
                Display("2. A-decorated : ", new DecoratorA(component));
                Display("3. B-decorated : ", new DecoratorB(component));
                Display("4. B-A-decorated : ", new DecoratorB(new DecoratorA(component)));
                // Explicit DecoratorB
                DecoratorB b = new DecoratorB(new Component());
                Display("5. A-B-decorated : ", new DecoratorA(b));

                // Invoking its added state and added behavior
                Console.WriteLine("\t\t\t" + b.addedState + b.AddedBehavior());

            #endregion


            Console.Read();

        }
    }
}

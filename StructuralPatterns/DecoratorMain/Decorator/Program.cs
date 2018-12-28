using Decorator.DecoratorOrginalPattern;
using Decorator.DecoratorOrginalPattern.ConcreteClasses;
using Decorator.DecoratorOrginalPattern.Interfaces;
using Decorator.GoF_DecoratorRealWorldExample;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region O'Reilly C# Design Pattern - Decorator Example

                RunDecoratorOrginalExample.Run();

            #endregion

            #region Gang of Four - Decorator Real World Example

                RunGoFDecoratorRealWorldExample.Run();

            #endregion

            Console.Read();

        }
    }
}

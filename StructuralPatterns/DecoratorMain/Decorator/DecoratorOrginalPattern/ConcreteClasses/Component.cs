using Decorator.DecoratorOrginalPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DecoratorOrginalPattern.ConcreteClasses
{
    class Component : IComponent
    {
        public string Operation()
        {
            return "I am walking ";
        }
    }
}

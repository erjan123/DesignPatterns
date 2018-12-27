using Decorator.DecoratorOrginalPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.DecoratorOrginalPattern.ConcreteClasses
{
    class DecoratorB : IComponent
    {
        IComponent _component;
        public string addedState = "past the Coffee Shop ";

        public DecoratorB(IComponent component)
        {
            _component = component;
        }
        public string Operation()
        {
            string s = _component.Operation();
            s += "to school ";
            return s;
        }

        public string AddedBehavior()
        {
            return "and I bought a cappuccino ";
        }
    }
}

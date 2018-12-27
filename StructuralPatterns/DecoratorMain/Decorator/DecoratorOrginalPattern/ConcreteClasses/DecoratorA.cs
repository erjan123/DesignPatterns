using Decorator.DecoratorOrginalPattern.Interfaces;

namespace Decorator.DecoratorOrginalPattern.ConcreteClasses
{
    class DecoratorA: IComponent
    {
        IComponent _component;

        public DecoratorA(IComponent component)
        {
            _component = component;
        }
        public string Operation()
        {
            string s = _component.Operation();
            s += "and listening to Classic FM ";
            return s;
        }
    }
}

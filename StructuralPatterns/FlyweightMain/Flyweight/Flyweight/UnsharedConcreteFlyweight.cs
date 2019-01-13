using System;

namespace DoFactory.GangOfFour.Flyweight.Structural
{
    class UnsharedConcreteFlyweight : Flyweight

    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +
              extrinsicstate);
        }
    }
}

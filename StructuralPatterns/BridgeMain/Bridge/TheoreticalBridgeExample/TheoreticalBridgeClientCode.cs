using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.TheoreticalBrideExample
{
    partial class BridgePattern
    {

        public static void Run()
        {
            Console.WriteLine("Bridge Pattern\n");
            //Console.WriteLine(new Abstraction(new ImplementationA()).Operation());
            //Console.WriteLine(new Abstraction(new ImplementationB()).Operation());
            IBridge implementationA = new ImplementationA();
            IBridge implementationB = new ImplementationB();

            var abstraction1 = new Abstraction(implementationA);
            Console.WriteLine(abstraction1.Operation());
            var abstraction2 = new Abstraction(implementationB);
            Console.WriteLine(abstraction2.Operation());
        }
    }
}

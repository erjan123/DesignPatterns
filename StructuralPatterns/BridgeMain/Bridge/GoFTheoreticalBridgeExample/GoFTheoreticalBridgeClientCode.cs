using System;

namespace DoFactory.GangOfFour.Bridge.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Bridge Design Pattern.
    /// </summary>
    public class GoFTheoreticalBridgeClient
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Run()
        {
            Console.WriteLine("DoFactory GangOfFour Bridge Structural example.");
            Console.WriteLine();

            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}

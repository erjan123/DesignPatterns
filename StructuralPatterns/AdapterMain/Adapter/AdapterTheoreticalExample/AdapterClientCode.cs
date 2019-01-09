using System;

namespace Adapter.AdapterTheoreticalExample
{
    public static class AdapterClient
    {
        public static void Run()
        {
            Console.WriteLine("Adapter Pattern Theoritical Example.");
            Console.WriteLine();

            // Showing the Adapteee in standalone mode
            Adaptee first = new Adaptee();
            Console.Write("Before the new standard\nPrecise reading: ");
            Console.WriteLine(first.SpecificRequest(5, 3));

            // What the client really wants
            ITarget second = new Adapter();
            Console.WriteLine("\nMoving to the new standard");
            Console.WriteLine(second.Request(5));

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}

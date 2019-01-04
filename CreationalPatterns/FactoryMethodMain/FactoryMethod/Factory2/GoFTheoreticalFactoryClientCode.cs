using System;

namespace DoFactory.GangOfFour.FactoryMethod.Structural
{
    /// <summary>
    /// MainApp startup class for Structural
    /// Factory Method Design Pattern.
    /// </summary>
    public static class GofFFacotryExample
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Run()
        {
            // An array of creators
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            // Iterate over creators and create products
            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                  product.GetType().Name);
            }

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}

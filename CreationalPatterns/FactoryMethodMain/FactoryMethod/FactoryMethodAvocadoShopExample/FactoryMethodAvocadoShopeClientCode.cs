using System;

namespace FactoryMethod.FactoryMethodAvocadoShopExample
{
    partial class FactoryPattern
    {
        public static void Run()
        {
            Creator c = new Creator();
            IProduct product;

            for (int i = 1; i <= 12; i++)
            {
                product = c.FactoryMethod(i);
                Console.WriteLine("Avocados " + product.ShipFrom());
            }

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}

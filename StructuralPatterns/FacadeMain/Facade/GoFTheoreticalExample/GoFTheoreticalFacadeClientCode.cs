using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.GoFTheoreticalExample
{

    /// <summary>
    /// MainApp startup class for Structural
    /// Facade Design Pattern.
    /// </summary>
    public static class GoFTheoreticalFacadeExample
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Run()
        {
            Facade facade = new Facade();
                
            facade.MethodA();
            facade.MethodB();

            // Wait for user
            Console.ReadKey();
        }
    }
}

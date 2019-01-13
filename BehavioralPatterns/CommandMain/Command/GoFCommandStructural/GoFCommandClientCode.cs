using System;
using System.Collections.Generic;
using System.Text;

namespace Command.GoFCommandStructural
{

    /// <summary>
    /// MainApp startup class for Structural
    /// Command Design Pattern.
    /// </summary>
    public static partial class GoFCommandClientCode
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Run()
        {
            // Create receiver, command, and invoker
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Set and execute command
            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}


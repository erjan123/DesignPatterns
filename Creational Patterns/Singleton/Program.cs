using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Logger1 a = new Logger1(); - cannot create a new Logger
            Logger1.Instance.LogMessage("Please Log this message!");
            Logger1.Instance.LogMessage("Please Log this message, too!");

            Console.WriteLine();
            // Logger2 a = new Logger2; - cannot create a new Logger2
            // GetInstance() method returns the only single Logger2 instance
            Logger2.GetInstance().LogMessage("Can you Log this message?");
            Logger2.GetInstance().LogMessage("Can you Log this message, too?");

            Console.Read();
        }
    }
}

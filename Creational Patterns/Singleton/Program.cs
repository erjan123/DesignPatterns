using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton with Static field implementation
            // Logger1 a = new Logger1(); - cannot create a new Logger
            Logger1.GetInstance.LogMessage("Please Log this message!");

            // GetInstance() method returns the only single Logger2 instance
            Logger2.GetInstance().LogMessage("Can you Log this message?");

            // Simple Thread safe implementation
            Logger3.GetInstance.LogMessage("Thread-safe implementation.");

            // Thread safety with double check
            Logger4.GetInstance.LogMessage("Thread-safety with double Check.");

            // Thread-safety without lock
            Logger5.Instance.LogMessage("Thread-safety without lock.");

            Console.Read();
        }
    }
}

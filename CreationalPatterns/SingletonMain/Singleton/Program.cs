using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton with Static field implementation
            // Logger1 a = new Logger1(); - cannot create a new Logger
            Logger1.GetInstance.LogMessage("Singleton with Static field.");

            // GetInstance() method returns the only single Logger2 instance
            Logger2.GetInstance().LogMessage("With  GetInstance()  method.");

            // Simple Thread safe implementation
            Logger3.GetInstance.LogMessage("Thread-safe implementation.");

            // Thread safety with double check
            Logger4.GetInstance.LogMessage("Thread-safety with double Check.");

            // Thread-safety without lock
            Logger5.GetInstance.LogMessage("Thread-safety without lock.");

            // Thread-safety without lock - using propertiy with lambda
            Logger5b.GetInstance.LogMessage("Thread-safety without lock - using propertiy with lambda");

            // Thread-safety without lock - with auto property
            Logger5c.GetInstance.LogMessage("Thread-safety without lock - with auto property");

            // Lazy instantiation with Lazy<T> 
            Logger6.GetInstance.LogMessage("Lazy instantiation with Lazy<T> ");

            // Lazy instantiation with Nested classes
            Logger7.GetInstance.LogMessage("Lazy instantiation with Nested classes.");

            /***********************************************************************************/
            //GenericLogger
            Console.WriteLine("\r\n\r\nGeneric Logger:");
            FileLogger fileLoggerInstance = GenericLogger<FileLogger>.GetInstance();
            fileLoggerInstance.Log("Log a file with FileLogger.");

            EventLogger eventLoggerInstance = GenericLogger<EventLogger>.GetInstance();
            eventLoggerInstance.Log("Log an event with EventLogger.");
           
            /***********************************************************************************/

            Console.WriteLine("\r\n\r\nBadAssSingleton:");
            BadAssSingleton badAssSingleton = BadAssSingleton.OnlyInstance;
            badAssSingleton.LogMessage("Log Message.");
            badAssSingleton.Dispose();

            Console.Read();
        }
    }
}

using System;

namespace Singleton
{
    public class Logger1
    {
        // Singleton with Static field implementation
        static Logger1 instance;
        private Logger1 () { } // Private constructor - nobody can create (instantiate) an
                              // Logger1 Object

        // Property that returns the only Logger1 instance
        public static Logger1 Instance
        {
            get
            {
                return instance != null ? instance : new Logger1();
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 1: " + message);
        }
    }

    public class Logger2
    {
        // This time we are going to use a method to return the same instance
        static Logger2 instance;

        private Logger2() { }

        public static Logger2 GetInstance()
        {
            return instance != null ? instance : new Logger2();
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 2: " + message);
        }

    }
}

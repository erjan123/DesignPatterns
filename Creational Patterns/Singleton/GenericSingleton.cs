using System;
using System.Reflection;

namespace Singleton
{
    // This interface will be used as a constrain for the Generic Interface
    public interface ILogger
    {
        void Log(string message);
    }

    // Regular class that inherits ILogger with private constructor
    // and a Counter property to test the Singleton 
    public sealed class FileLogger : ILogger
    {
        public int Counter { get; set; } // Created to test FileLogger Singleton

        internal protected FileLogger() { }

        public void Log(string message)
        {
            Console.WriteLine("FileLogger : " + message);
        }
    }

    // Regular class that inherits ILogger with private constructor
    // and a Counter property to test the Singleton 
    public sealed class EventLogger : ILogger
    {
        public int Counter { get; set; } // Created to test FileLogger Singleton

        internal protected EventLogger() { }

        public void Log(string message)
        {
            Console.WriteLine("EventLogger : " + message);
        }
    }

    // Generic class that will used to create a singleton object - in this example we will 
    // create a FileLogger or Event Logger
    public class GenericLogger<T> where T: class, ILogger
    {
        private static T instance = default(T);
        private static readonly object padlock = new object();

        private GenericLogger() { }

        // Use a method to create or return the only instance
        public static T GetInstance()
        {
            if (instance == null)
                CreateSingleInstance();
            return instance;
        }

        // double check for thread safety
        private static void CreateSingleInstance()
        {
            lock(padlock)
            {
                if(instance == null)
                {
                    Type t = typeof(T);

                    ConstructorInfo[] ctors = t.GetConstructors();

                    // Ensure there are no public constructors
                    if (ctors.Length > 0)
                        throw new InvalidOperationException();

                    instance = Activator.CreateInstance(t, true) as T;
                }
            }
        }
    }

}

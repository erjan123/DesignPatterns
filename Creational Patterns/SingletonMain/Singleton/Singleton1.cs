using System;

namespace Singleton
{
    // Singleton with Static field implementation
    public sealed class Logger1
    {
        static readonly Logger1 instance = null;

        private Logger1() { } // Private constructor - nobody can create (instantiate) an
                              // Logger1 Object

        // Property that returns the only Logger1 instance
        public static Logger1 GetInstance
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

    // GetInstance() method returns the single instance
    public sealed class Logger2
    {

        static readonly Logger2 instance = null;

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

    // Simple Thread safe implementation
    public sealed class Logger3
    {
        static readonly Logger3 instance = null;
        public static readonly object padlock = new object();

        private Logger3() { } // Private constructor - nobody can create (instantiate) an
                              // Logger3 Object

        // Property that returns the only Logger3 instance
        public static Logger3 GetInstance
        {
            get
            {
                lock (padlock)
                {
                    return instance != null ? instance : new Logger3();
                }
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 3: " + message);
        }
    }

    // Thread safety with double check
    public sealed class Logger4
    {
        static readonly Logger4 instance = null;
        public static readonly object padlock = new object();

        Logger4() { } // Private constructor 

        // Property that returns the only Logger4 instance
        public static Logger4 GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                            return new Logger4();
                    }
                }

                return instance;
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 4: " + message);
        }
    }

    // Thread-safety without lock
    public sealed class Logger5
    {
        private static readonly Logger5 instance = new Logger5();

        static Logger5() { }
        Logger5() { }

        public static Logger5 Instance
        {
            get
            {
                return instance;
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 5: " + message);
        }
    }

    // Thread-safety without lock - using propertiy with lambda
    public sealed class Logger5b
    {
        private static readonly Logger5b instance = new Logger5b();

        static Logger5b() { }
        Logger5b() { }

        public static Logger5b Instance => instance;

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 5b: " + message);
        }
    }

    // Thread-safety without lock - with auto property
    public sealed class Logger5c
    {
        static Logger5c() { }
        Logger5c() { }

        public static Logger5c Instance { get; } = new Logger5c();

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 5c: " + message);
        }
    }

    // Lazy instantiation with Lazy<T>
    public sealed class Logger6
    {
        private static readonly Lazy<Logger6> instance =  new Lazy<Logger6>(() => new Logger6());

        private Logger6() { }

        public static Logger6 Instance
        {
            get { return instance.Value; }         
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 6: " + message);
        }
    }

    // Lazy instantiation with Nested classes
    public sealed class Logger7
    {
        Logger7() { }

        public static Logger7 Instance { get { return Nested.instance; } }

        private class Nested
        {
            static Nested()
            {
            }

            internal static readonly Logger7 instance = new Logger7();
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 7: " + message);
        }
    }


}

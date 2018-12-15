using System;

namespace Singleton
{
    // Singleton with Static field implementation
    public sealed class Logger1
    {
        static Logger1 instance = null;
        public int Counter { get; set; }
        private Logger1() { } // Private constructor - nobody can create (instantiate) an
                              // Logger1 Object

        // Property that returns the only Logger1 instance
        public static Logger1 GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Logger1();

                return instance;
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
        static Logger2 instance = null;
        public int Counter { get; set; }
        private Logger2() { }

        public static Logger2 GetInstance()
        {
            if(instance == null)
                instance = new Logger2();

            return instance;
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 2: " + message);
        }
    }

    // Simple Thread safe implementation
    public sealed class Logger3
    {
        static Logger3 instance = null;
        public static  object padlock = new object();
        public int Counter { get; set; }

        private Logger3() { } // Private constructor - nobody can create (instantiate) an
                              // Logger3 Object

        // Property that returns the only Logger3 instance
        public static Logger3 GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                        instance = new Logger3();

                    return instance;
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
        private static Logger4 instance = null;
        public static readonly object padlock = new object();
        public int Counter { get; set; }

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
                            instance = new Logger4();
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
        public int Counter { get; set; }

        static Logger5() { }
        Logger5() { }

        public static Logger5 GetInstance
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
        public int Counter { get; set; }

        static Logger5b() { }
        Logger5b() { }

        public static Logger5b GetInstance => instance;

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 5b: " + message);
        }
    }

    // Thread-safety without lock - with auto property
    public sealed class Logger5c
    {
        public int Counter { get; set; }
        static Logger5c() { }
        Logger5c() { }

        public static Logger5c GetInstance { get; } = new Logger5c();

        public void LogMessage(string message)
        {
            Console.WriteLine("Logger 5c: " + message);
        }
    }

    // Lazy instantiation with Lazy<T>
    public sealed class Logger6
    {
        private static readonly Lazy<Logger6> instance =  new Lazy<Logger6>(() => new Logger6());
        public int Counter { get; set; }

        private Logger6() { }

        public static Logger6 GetInstance
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

        public static Logger7 GetInstance { get { return Nested.instance; } }
        public int Counter { get; set; }

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

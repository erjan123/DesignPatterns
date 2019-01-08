using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    // Basically this Singleton is same as double check locking
    // However, using static "volatile" on onlyInstance makes it real thread save
    // IDisposable is not part of Singleton but Microsoft recommends to 
    // method that will dispose the instance
    public sealed class BadAssSingleton: IDisposable
    {
        private static volatile BadAssSingleton onlyInstance;
        private static readonly object padlock = new object();

        private readonly bool _disposed;
        public int Counter = default(int);
        
        private BadAssSingleton() { }

        public static BadAssSingleton OnlyInstance
        {
            get
            {
                if (onlyInstance != null)
                    return onlyInstance;

                lock(padlock)
                {
                    if (onlyInstance == null)
                        onlyInstance = new BadAssSingleton();
                }
                return onlyInstance;
            }
        }

        public void LogMessage(string message)
        {
            Console.WriteLine("BadAss Singleton : " + message);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;
            if (disposing)
                onlyInstance = null;
        }
    }
}

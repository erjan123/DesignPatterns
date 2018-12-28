using System;
using static SubjectAccessor;

namespace ProxyTheoreticalExample
{
    public static class ProxyClientCode
    {
        public static void Run()
        {
            Console.WriteLine("Proxy Pattern\n");

            ISubject subject = new SubjectAccessor.Proxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine(subject.Request());
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();  
        }
    }
}

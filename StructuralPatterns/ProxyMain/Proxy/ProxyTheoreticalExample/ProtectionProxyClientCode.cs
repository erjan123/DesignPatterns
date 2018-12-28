using System;
using static SubjectAccessor;

namespace ProxyTheoreticalExample
{
    public static class ProtectionProxyClientCode
    {
        public static void Run()
        {
            Console.WriteLine("Protection Proxy Pattern\n");

            ISubject subject = new ProtectionProxy();
            Console.WriteLine(subject.Request());
            Console.WriteLine((subject as ProtectionProxy).Authenticate("Secret"));
            Console.WriteLine((subject as ProtectionProxy).Authenticate("Abracadabra"));
            Console.WriteLine(subject.Request());

            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}

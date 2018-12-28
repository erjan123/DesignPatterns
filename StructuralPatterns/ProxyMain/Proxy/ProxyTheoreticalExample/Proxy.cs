using System;

partial class SubjectAccessor
{
    public class Proxy : ISubject
    {
        Subject subject;

        public string Request()
        {
            // A virtual proxy creates the object only on its first method call
            if (subject == null)
            {
                Console.WriteLine("Subject inactive");
                subject = new Subject();
            }
            Console.WriteLine("Subject active");
            return "Proxy: Call to " + subject.Request();
        }
    }
}


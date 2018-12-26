using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod.EmailServiceProviders
{
    class HotmailEmailService : IEmailService
    {
        public void ProcessEmail()
        {
            Console.WriteLine("Sending emails with Hotmail.");
        }
    }
}

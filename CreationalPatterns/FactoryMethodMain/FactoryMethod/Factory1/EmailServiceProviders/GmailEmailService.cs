using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.EmailServiceProviders
{
    public class GmailEmailService : IEmailService
    {
        public void ProcessEmail()
        {
            Console.WriteLine("Sending emails with Gmail.");
        }
    }
}

using FactoryMethod.EmailServiceProviders;
using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod.EmailManagers
{
    public class GmailManager : IEmailManager
    {
        private IEmailService emailService { get; set; }

        public GmailManager()
        {
            Console.WriteLine("Creating GmailEmailService");
            emailService = new GmailEmailService();
        }

        public void SentEmail()
        {
            Console.WriteLine("Gmail Manager is using Gmail Email Service.");
            emailService.ProcessEmail(); ;
        }
    }
}

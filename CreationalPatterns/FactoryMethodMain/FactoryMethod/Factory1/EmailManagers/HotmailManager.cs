using FactoryMethod.EmailServiceProviders;
using FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.EmailManagers
{
    public class HotmailManager : IEmailManager
    {
        private IEmailService emailService { get; set; }

        public HotmailManager()
        {
            emailService = new HotmailEmailService();
        }

        public void SentEmail()
        {
            Console.WriteLine("Hotmail Manager is using Hotmail Email Service.");
            emailService.ProcessEmail(); ;
        }
    }
}

using FactoryMethod.EmailServiceProviders;
using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod.EmailManagers
{
    public class YahooManager : IEmailManager
    {
        private IEmailService emailService { get; set; }

        public YahooManager()
        {
            Console.WriteLine("Creating YahooEmailService");
            emailService = new YahooEmailService();
        }

        public void SentEmail()
        {
            Console.WriteLine("Yahoo Manager is using Yahoo Email Service.");
            emailService.ProcessEmail(); ;
        }
    }
}

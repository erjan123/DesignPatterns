using FactoryMethod.EmailManagers;
using System;

namespace FactoryMethod.Factory1
{
    public class FactoryExample1ClientCode
    {
        public static void Run()
        {
            // Factory design pattern is used internally from these there
            // classes (YahooManager, GmailManager, HotmailManager)
            var yahooServiceManager = new YahooManager();
            var gmailServiceManager = new GmailManager();
            var hotmailServiceManager = new HotmailManager();

            Console.WriteLine();
            yahooServiceManager.SentEmail();
            Console.WriteLine();
            gmailServiceManager.SentEmail();
            Console.WriteLine();
            hotmailServiceManager.SentEmail();
            
            Console.WriteLine();
            Console.WriteLine("******************************************");
            Console.WriteLine();
        }
    }
}

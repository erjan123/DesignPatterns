using FactoryMethod.EmailManagers;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

                // Factory design pattern is used internally from these there
                // classes (YahooManager, GmailManager, HotmailManager)
                var yahooServiceManager = new YahooManager();
                var gmailServiceManager = new GmailManager();
                var hotmailServiceManager = new HotmailManager();

                yahooServiceManager.SentEmail();
                Console.WriteLine();
                gmailServiceManager.SentEmail();
                Console.WriteLine();
                hotmailServiceManager.SentEmail();
                Console.WriteLine();

            #endregion  

            Console.Read();
        }
    }
}

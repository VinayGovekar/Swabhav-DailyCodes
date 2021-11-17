using System;
using PublisherLib.Publisher;
using SubscriberClientApp.Subscriber;

namespace SubscriberClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Vinay", 101, 5000, "vg@gmail.com");
            account1.AddNotifier(new SmsNotifier());
            account1.AddNotifier(new EmailNotifier());
            account1.Deposit(100);
            Console.ReadKey();
        }
    }
}

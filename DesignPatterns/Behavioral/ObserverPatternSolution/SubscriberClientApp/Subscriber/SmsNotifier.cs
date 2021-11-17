using System;
using PublisherLib.Publisher;
namespace SubscriberClientApp.Subscriber
{
    public class SmsNotifier : INotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Sms sent to account number: {0}",account.GetAccountNumber());
        }
    }
}

using System;
using PublisherLib.Publisher;

namespace SubscriberClientApp.Subscriber
{
    public class EmailNotifier : INotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Email sent to account number: {0} , Email Id: {1}",account.GetAccountNumber(),account.Email);
        }
    }
}

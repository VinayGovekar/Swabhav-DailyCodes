using System;
using NotifierDecoratorApp.Model;
using NotifierDecoratorApp.Model.Decorator;
namespace NotifierDecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // var notifier = new SlackNotifier(new FacebookNotifier(new SmsNotifier(
            //              new WhatsappNotifier(new StandardNotifier()))));
            var notifier = new StandardNotifier();
            notifier.SendMessage("How are you?");
            Console.WriteLine(notifier.GetMessagePath());
            Console.ReadKey();
        }
    }
}

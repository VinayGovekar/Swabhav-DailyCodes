using System;

namespace NotifierDecoratorApp.Model
{
    public abstract class Notifier
    {
        public void SendMessage(string message) 
        {
            Console.WriteLine("\nMessage: {0}\n", message);
        }
        public abstract string GetMessagePath();
    }
}

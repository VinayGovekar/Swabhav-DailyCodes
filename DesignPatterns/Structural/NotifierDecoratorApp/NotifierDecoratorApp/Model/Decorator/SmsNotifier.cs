using System;

namespace NotifierDecoratorApp.Model.Decorator
{
    public class SmsNotifier:Notifier
    {
        private Notifier _notifier;
        public SmsNotifier(Notifier notifier)
        {
            _notifier = notifier;
        }

        public override string GetMessagePath()
        {
            return _notifier.GetMessagePath() + "\nSMS Notifier";
        }
      
    }
}

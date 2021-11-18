using System;


namespace NotifierDecoratorApp.Model.Decorator
{
    public class WhatsappNotifier : Notifier
    {
        private Notifier _notifier;
        public WhatsappNotifier(Notifier notifier)
        {
            _notifier = notifier;
        }
        public override string GetMessagePath()
        {
            return _notifier.GetMessagePath() + "\nWhatsapp Notifier";
        }
    }
}

using System;


namespace NotifierDecoratorApp.Model.Decorator
{
    public class FacebookNotifier:Notifier
    {
        private Notifier _notifer;
        public FacebookNotifier(Notifier notifier)
        {
            _notifer = notifier;
        }

        public override string GetMessagePath()
        {
            return _notifer.GetMessagePath() + "\nFacebook Notifier";
        }

    }
}

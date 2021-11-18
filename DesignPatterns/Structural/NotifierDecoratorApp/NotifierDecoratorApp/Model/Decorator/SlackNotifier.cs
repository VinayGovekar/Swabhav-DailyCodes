using System;

namespace NotifierDecoratorApp.Model.Decorator
{
    public class SlackNotifier:Notifier
    {
        private Notifier _notifier;
        public SlackNotifier(Notifier notifier)
        {
            _notifier = notifier;
        }

        public override string GetMessagePath()
        {
            return _notifier.GetMessagePath() + "\nSlack Notifier";
        }
    }
}

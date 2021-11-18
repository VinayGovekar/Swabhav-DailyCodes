using System;


namespace NotifierDecoratorApp.Model
{
    public class StandardNotifier : Notifier
    {
        public override string GetMessagePath()
        {
            return "Sent via:\nStandard Notifier";
        }
    }
}

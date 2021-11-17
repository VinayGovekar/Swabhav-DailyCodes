using System;


namespace FactoryMethodClientApp
{
    public class NoSuchElementPresentException:Exception
    {
        public override string Message
        {
            get
            {
                return "Input element not present!";
            }
        }
    }
}

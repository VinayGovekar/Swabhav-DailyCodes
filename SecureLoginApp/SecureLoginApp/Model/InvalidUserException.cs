using System;
namespace SecureLoginApp.Model
{
    public class InvalidUserException:Exception
    {
        public override string Message
        {
            get
            {
                return "Invalid User entered!!!";
            }
        }
    }
}

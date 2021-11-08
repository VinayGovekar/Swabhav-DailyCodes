using System;
namespace CustomExceptionApp
{
    class AgeLessThenZeroException:Exception
    {
        public AgeLessThenZeroException():base(String.Format("Age cannot be negetive"))
        {
        }
        
    }
}

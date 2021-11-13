using System;
namespace DIPViolationApp.LowLevelModule
{
    public class DBLogger
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine("Logging to DB\nMessage: {0}",msg);
        }
    }
}

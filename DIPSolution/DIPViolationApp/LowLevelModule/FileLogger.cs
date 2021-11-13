using System;

namespace DIPViolationApp.LowLevelModule
{
    public class FileLogger
    {
        public void WriteLine(string msg)
        {
            Console.WriteLine("Logging to file\nMessage: {0}",msg);
        }
    }
}

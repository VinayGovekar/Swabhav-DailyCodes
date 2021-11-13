using System;
using DIPSolutionApp.CommonModule;
namespace DIPSolutionApp.LowLevelModule
{
    public class FileLogger:ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine("Logging to File\nMessage: {0}",msg);
        }
    }
}

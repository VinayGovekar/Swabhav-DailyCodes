using System;
using DIPSolutionApp.CommonModule;
namespace DIPSolutionApp.LowLevelModule
{
    public class DBLogger:ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine("Logging to DB\nMessage: {0}",msg);
        }
    }
}

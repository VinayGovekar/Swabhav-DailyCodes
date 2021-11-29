using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAndThreadApp.Model
{
    public class TimePrinter
    {
        public void PrintDelay()
        {
            var startTime = DateTime.Now;
            while((DateTime.Now-startTime).TotalMilliseconds < 5 * 1000)
            {
                Console.WriteLine(DateTime.Now);
            }
            Console.WriteLine("Delay over");
        }

        public Task<int> PrintAsync()
        {
            return Task.Run(() =>
            {
                PrintDelay();
                return 10;
            });
        }
    }
}

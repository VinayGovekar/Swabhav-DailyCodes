using System;
using System.Threading;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread t1 = new Thread(() =>
            {
                Dataservice.GetInstance().DoSomething();
            });

            Thread t2 = new Thread(() =>
            {
                Dataservice.GetInstance().DoSomething();
            });
            t1.Start();
            t2.Start();

            Console.ReadKey();
        }
        public static void CaseStudy1()
        {
            var service1 = Dataservice.GetInstance();
            var service2 = Dataservice.GetInstance();
            Console.WriteLine(service1.GetHashCode());
            Console.WriteLine(service2.GetHashCode());

            service1.DoSomething();
            service2.DoSomething();
            Console.ReadKey();
        }
    }
}

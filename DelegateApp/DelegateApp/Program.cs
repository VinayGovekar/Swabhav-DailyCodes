using System;

namespace DelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new SampleClass();
            obj.LongRunningMethod(CallBack);
            Console.ReadKey();
        }
        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
        class SampleClass
        {
            public delegate void CallBack(int i);
            public void LongRunningMethod(CallBack callBack)
            {

                for(int i = 0; i < 100000; i++)
                {
                    //Doing something
                    callBack(i);
                }
            }
        }
    }
}

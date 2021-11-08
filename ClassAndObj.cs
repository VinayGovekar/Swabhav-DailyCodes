using System;
namespace CmdLineApp
{
    class ClassAndObj
    {
        class Mobile
        {
            public int RAM;
            public int ROM;
            public double Camera;
            public Mobile(int Ram, int Rom, double camera)
            {
                RAM = Ram;
                ROM = Rom;
                Camera = camera;
            }
        }
       
        public static void Main(string[] args)
        {
            Mobile SamsungMobile = new Mobile(8,64,13.54);
            Mobile OnePlusMobile = new Mobile(12, 129, 24.54);
            Console.WriteLine("Samsung Specs: {0} {1} {2}", SamsungMobile.RAM, SamsungMobile.ROM, SamsungMobile.Camera);

            Console.WriteLine("\nOnePlus Specs: {0} {1} {2}",OnePlusMobile.RAM,OnePlusMobile.ROM,OnePlusMobile.Camera);
            Console.ReadLine();
        }
    }
}

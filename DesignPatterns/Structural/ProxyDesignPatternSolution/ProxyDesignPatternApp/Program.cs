using System;
using ProxyDesignPatternApp.Model;


namespace ProxyDesignPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            CaseStudy2();

            Console.ReadKey();
        }

        static void CaseStudy1()
        {
            var img1 = new RealImage("img1.jpg");
            var img2 = new RealImage("img2.jpg");
            var img3 = new RealImage("Img3.jpg");

            img3.Display();
        }

        static void CaseStudy2()
        {
            var img4 = new ProxyImage("img4.jpg");
            var img5 = new ProxyImage("img5.jpg");
            var img6 = new ProxyImage("img6.jpg");

            img6.Display();
        }
    }
}

using System;
using InterfaceApp.Model;

namespace InterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Boy boy = new Boy();
            AtTheParty(man);
            AtTheParty(boy);
            AtTheCinemaHall(man);
            AtTheCinemaHall(boy);
        }
        public static void AtTheParty(IManner imObj)
        {
            Console.WriteLine("At the Party");
            imObj.Wish();
            imObj.Depart();
        }
        public static void AtTheCinemaHall(IEmotion ieObj)
        {
            Console.WriteLine("At the Cinema Hall");
            ieObj.Cry();
            ieObj.Laugh();
        }
    }
}

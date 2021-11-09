using System;
using DogDoorApp.Model;

namespace DogDoorApp
{
    class DogDoorSimulator
    {
        static void Main(string[] args)
        {
            Remote remote = new Remote(new DogDoor());
            CaseStudy1(remote);
            Console.ReadKey();
        }
        public static void CaseStudy1(Remote remote)
        {
            Console.WriteLine("\nDog is barking and wants to go outside."+
                              "\nOwner listens to the barking and presses the button on remote"+
                              "\nDog goes outside and do its business");
            remote.PressButton();
            Console.WriteLine("\nBut the door is closed before it comes back"+
                              "\nDog barks again and Owner listens\nOwner presses the button for opening of door"+
                              "\nDog comes back inside");
            remote.PressButton();
            Console.WriteLine("\nOwner is happy");
        }
    }
}

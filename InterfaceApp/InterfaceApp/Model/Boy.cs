using System;


namespace InterfaceApp.Model
{
    class Boy : IManner, IEmotion
    {
        public void Cry()
        {
            Console.WriteLine("Boy is crying");
        }

        public void Depart()
        {
            Console.WriteLine("Boy says goodbye");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy laughs");
        }

        public void Wish()
        {
            Console.WriteLine("Boy Wishes");
        }
    }
}

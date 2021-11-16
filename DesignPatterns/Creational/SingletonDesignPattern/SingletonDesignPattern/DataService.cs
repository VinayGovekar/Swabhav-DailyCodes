using System;


namespace SingletonDesignPattern
{
    public class Dataservice
    {
        private static object contextLock = new object();
        private static Dataservice bucket;
        private Dataservice()
        {
            Console.WriteLine("DataService Created");
        }
        public void DoSomething()
        {
            Console.WriteLine("Work done by {0}",this.GetHashCode());
        }
        public static Dataservice GetInstance()
        {
            lock (contextLock)
            {
                if (bucket == null) bucket = new Dataservice();
            }
            return bucket;
        }
    }
}

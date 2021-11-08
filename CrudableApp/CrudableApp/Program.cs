using System;
using CrudableApp.Model;

namespace CrudableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoOperations(new PremiumCustomerDB());
            DoOperations(new ProductDB());
            DoOperations(new OrderDB());
            Console.ReadLine();
        }
        public static void DoOperations(ICrudable obj)
        {
            Console.WriteLine("\n\nDoing all DB operations: \n");
            obj.Create();
            obj.Read();
            obj.Update();
            obj.Delete();
        }
    }
}

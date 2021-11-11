using System;
using SecureLoginApp.Model;
namespace SecureLoginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SecurityService service = new SecurityService();
                PrintDetails(service.Login("vg101", "vg@101"));
            }
            catch (InvalidUserException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.ReadLine();

        }
        public static void PrintDetails(UserView user)
        {
            Console.WriteLine("Name: {0}\nEmail: {1}",user.FirstName+user.LastName,user.Email);
        }
    }
}

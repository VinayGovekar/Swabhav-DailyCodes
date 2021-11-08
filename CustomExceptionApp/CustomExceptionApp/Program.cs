using System;


namespace CustomExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ValidateAge(-10);
            }
            catch(AgeLessThenZeroException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();

        }

        public static void ValidateAge(int age)
        {
            if (age < 0) throw new AgeLessThenZeroException();
        }
    }
}

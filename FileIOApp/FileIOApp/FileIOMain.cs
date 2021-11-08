using System;
namespace FileIOApp
{
    class FileIOMain
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }
        public static void CaseStudy1()
        {
            File fileObj = new File();
            int choice = 0;
            Console.WriteLine("\n\t\tFIle IO App");
            do
            {
                Console.WriteLine("\n1. Display\n2. Write to File\n3. Exit\n\nEnter Choice:");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1) fileObj.ReadData();
                else if(choice==2) fileObj.WriteData();
                else Console.WriteLine("Invalid Choice!!! Plz try again");
            } while (choice!=3);
        }
    }
}

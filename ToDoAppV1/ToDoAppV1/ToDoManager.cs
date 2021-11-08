using System;
using System.IO;
namespace ToDoAppV1
{
    class ToDoManager
    {
        static void Main(string[] args)
        {
            string filePath = Directory.GetCurrentDirectory() + "\\ToDoAppStorage.binary";
            ToDoList toDoObject= new ToDoList(filePath);
            Console.WriteLine("\n\t\tToDoAppV1");
            Console.WriteLine("\t\tDeveloped by: Vinay");
            
            int userChoice = 0;
            do
            {
                DisplayMenu();
                userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 1)
                {
                    DisplayItems(toDoObject);
                }
                else if(userChoice == 2)
                {
                    string continueChoice = "y";
                    do
                    {
                        Console.WriteLine("\nEnter item name:");
                        string itemName = Console.ReadLine();
                        toDoObject.AddItem(itemName);
                        Console.WriteLine("\nDo you want to continue adding items?(y/n)");
                        continueChoice = Console.ReadLine();
                    } while (continueChoice != "n");
                }
            } while (userChoice!=3);
            toDoObject.SerializeObject(filePath);
            SavingDelay();
        }
        private static void DisplayItems(ToDoList itemList)
        {
            if (itemList.ToDoListArray[0] == null)
            {
                Console.WriteLine("\nNo items to display");
            }
            else
            {
                int i = 0;
                Console.WriteLine("\nToDoList:");
                do
                {
                    Console.WriteLine("#{0}: {1}", i+1, itemList.ToDoListArray[i]);
                    i += 1;
                } while (itemList.ToDoListArray[i] != null);
            }
        }
        private static void DisplayMenu()
        {
            Console.WriteLine("\n*** Menu ***");
            Console.WriteLine("\n1. Display");
            Console.WriteLine("2. Add Item");
            Console.WriteLine("3. Exit");
            Console.WriteLine("\nEnter choice: ");
        }
    
        public static void SavingDelay()
        {
            Console.Write("\nSaving your items");
            for (int i=0;i<3;i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}

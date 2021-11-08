using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserializationApp
{
    class AccountTest
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            Console.ReadLine();
        }
        private static void CaseStudy1()
        {
            Account testObject = new Account();
            string filePath = "E:\\SwabhavTech\\C#\\OOP\\SerializationAndDeserializationApp\\SerializationAndDeserializationApp\\AccountObject.binary";
            Console.WriteLine("Origianl Balance:");
            PrintDetails(testObject);
            testObject.Deposit(1000f);
            Console.WriteLine("New Balance:");
            PrintDetails(testObject);
            SerializeObject(testObject,filePath);
            Account newObj = DeSerializeObject(filePath);
            Console.WriteLine("\nAfter Deserialization:");
            PrintDetails(newObj);
        }
        private static void SerializeObject(Account account,string filePath)
        {
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath)) File.Delete(filePath);
            Console.WriteLine("Serializing...");
            fileStream = File.OpenWrite(filePath);
            bf.Serialize(fileStream, account);
            fileStream.Close();
        }
        private static Account DeSerializeObject(string filePath)
        {
            FileStream fileStream;
            Account newObj = null;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                newObj = (Account)bf.Deserialize(fileStream);
            }
            else Console.WriteLine("\nNo file present!!!");
            return newObj;
        }
        private static void PrintDetails(Account account)
        {
            Console.WriteLine("Balance: {0}\n",account.Balance);
        }
    }
}

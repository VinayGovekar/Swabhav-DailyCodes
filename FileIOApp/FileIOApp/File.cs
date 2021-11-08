using System;
using System.IO;

namespace FileIOApp
{
    class File
    {
        public void WriteData()
        {
            FileStream fs = new FileStream("E:\\SwabhavTech\\C#\\OOP\\FileIOApp\\FileIOApp\\DisplayFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("\nEnter Name: ");
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("E:\\SwabhavTech\\C#\\OOP\\FileIOApp\\FileIOApp\\DisplayFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("\nContent of the File:");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }
}

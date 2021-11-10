using System;
using System.Reflection;
using ThisPointerApp.Model;

namespace ThisPointerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }
        private static void CaseStudy2()
        {
            Type typeObj = typeof(Player);
            MethodInfo[] methods = typeObj.GetMethods();
            PropertyInfo[] properties = typeObj.GetProperties();
            ConstructorInfo[] constructors = typeObj.GetConstructors();
            Console.WriteLine("\nConstructors:");
            foreach (var constructor in constructors)
            {
                Console.WriteLine("Constructor Name: {0}",constructor.Name);
                ParameterInfo[] parameters = constructor.GetParameters();
                foreach(var param in parameters) {
                    Console.WriteLine("Parameter Name: {0} , Paramter Type: {1}", param.Name,param.ParameterType);
                }
            }
            Console.WriteLine("\n\nMethods:");
            foreach (var method in methods)
            {
                Console.WriteLine("Method Name: {0}",method.Name);
                ParameterInfo[] parameters = method.GetParameters();
                foreach (var param in parameters)
                {
                    Console.WriteLine("Parameter Name: {0} , Paramter Type: {1}", param.Name, param.ParameterType);
                }
            }
            Console.WriteLine("\n\nProperties:");
            foreach (var property in properties)
            {
                Console.WriteLine("Property Name: {0}",property.Name);
            }
        }
        private static void CaseStudy1()
        {
            Player sachin = new Player("Sachin Tendulkar");
            PrintDetails(sachin);
            Player virat = new Player("Virat", 15, GenderType.Male);
            PrintDetails(virat);
            Console.WriteLine("\nElder Player is:");
            PrintDetails(virat.WhoIsElder(sachin));

        }
        private static void PrintDetails(Player player)
        {
            Console.WriteLine("\nName: {0}",player.Name);
            Console.WriteLine("Age: {0}",player.Age);
            Console.WriteLine("Gender: {0}",player.Gender);
            Console.WriteLine("HashCode: {0}", player.GetHashCode());
        }
    }
}

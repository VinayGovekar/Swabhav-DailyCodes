using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
namespace CustomAttributeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Foo);
            DisplayList(GetMethodsWithAttribute(type));
            Console.ReadLine();
        }
        public static Tuple<List<string>,List<string>> GetMethodsWithAttribute(Type type)
        {
            List<string> methodsList = new List<string>();
            List<string> typeList = new List<string>();
            MethodInfo[] methods = type.GetMethods();
            foreach (var method in methods)
            {
                if (method.GetCustomAttribute(typeof(NeedToRefractor)) is NeedToRefractor)
                {
                    methodsList.Add(method.Name);
                    typeList.Add(method.ReturnType.ToString().Split('.').Last()); 
                }
            }
            return Tuple.Create(methodsList,typeList);
        }
        public static void DisplayList(Tuple<List<string>,List<string>> stringList)
        {
            Console.WriteLine("Number of Methods with attribute: {0}\n",stringList.Item1.Count);
            for (int i = 0;  i<stringList.Item1.Count; i++) Console.Write("{0} {1}\n", stringList.Item2[i], stringList.Item1[i]);
        }
    }
}

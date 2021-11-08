using System;
using System.Reflection;
using System.Collections.Generic;

namespace MyUnitTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUnitClasses();
            Console.ReadLine();
        }

        public static void GetUnitClasses()
        {
            Assembly assem = Assembly.GetExecutingAssembly();
            Type[] types = assem.GetTypes();
            List<string> className = new List<string>();
            var resultSet = new List<(List<string>, List<string>)>();
            foreach (Type cls in types)
            {
                if (cls.GetCustomAttribute(typeof(MyUnitTestClass)) is MyUnitTestClass) 
                { 
                    resultSet.Add(GetUnitMethods(cls));
                    className.Add(cls.Name);
                }
            }
            DisplayInfo(resultSet, className);
        }
        public static (List<string>,List<string>) GetUnitMethods(Type cls)
        {
            List<string> result = new List<string>();
            List<string> methodNames = new List<string>();
            MethodInfo[] methods = cls.GetMethods();
            foreach(MethodInfo method in methods)
            {
                if(method.GetCustomAttribute(typeof(MyUnitTestMethod)) is MyUnitTestMethod)
                {
                    Type classType = Type.GetType(cls.FullName, true);
                    Object o = (Activator.CreateInstance(classType));
                    if((bool)method.Invoke(o, null)) result.Add("Passed");
                    else result.Add("Failed");
                    methodNames.Add(method.Name);
                }
            }
            return (methodNames, result);
        }
        public static void DisplayInfo(List<(List<string>, List<string>)> resultSet, List<string> className)
        {
            Console.WriteLine("TestClasses: {0}", resultSet.Count);
            for (int i = 0; i < className.Count; i++)
            {
                Console.WriteLine("\n\t{0}",className[i]);
                Console.WriteLine("\tTestCases: {0}",resultSet[i].Item1.Count);
                for(int j =0;j< resultSet[i].Item1.Count; j++)
                {
                    Console.WriteLine("\n\t\t{0} : {1}", resultSet[i].Item1[j], resultSet[i].Item2[j]);
                }
            }
        }
    }
}

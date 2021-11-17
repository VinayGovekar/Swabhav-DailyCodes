using System;
using FactoryMethodLib.Factory;
using System.Reflection;
using System.Configuration;

namespace FactoryMethodClientApp
{
    public class Reflector
    {
        public IAutoFactory GetInstanceFromAppConfig()
        {
            //Spliting user inputs
            string[] inputs = GetInput();
            string libraryName = inputs[0];
            string className = inputs[1];

            //Loading user entered library
            Assembly asm = Assembly.Load(libraryName);
            if (asm == null) throw new NoSuchElementPresentException();
            Type t = asm.GetType(className);

            //Will run if user enter wrong class name
            if (t == null) throw new NoSuchElementPresentException();

            //Getting GetInstance method
            IAutoFactory userClass = GetData(t.GetMethod("GetInstance"));
            return userClass;
        }
        private string[] GetInput()
        {
            string userInput = ConfigurationManager.AppSettings["factory"];
            string[] inputs = userInput.Split(',');
            return inputs;
        }
        private IAutoFactory GetData(MethodInfo method)
        {
            return (IAutoFactory)method.Invoke(null, null);
        }
    }
}

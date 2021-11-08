using System;
using PersonBMIApp.Model;

namespace PersonBMIApp
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            CaseStudy2();
            Console.ReadLine();
        }

        private static void CaseStudy1()
        {
            Person DemoPerson = new Person("Vinay", 22, "Male", 61.2f, 110.6014f);
            PrintDetails(DemoPerson);
            Console.WriteLine("\nAfter Workout:");
            DemoPerson.Workout();
            PrintDetails(DemoPerson);
            Console.WriteLine("\nAfter Eating:");
            DemoPerson.Eat();
            PrintDetails(DemoPerson);
            Console.WriteLine("\nCurrent Body Structure: {0}",CheckBodyStructure(DemoPerson));
        }
        private static void CaseStudy2()
        {
            Person[] manyPeople = new Person[4];
            manyPeople[0] = new Person("Vinay", 22, "Male", 61.2f, 110.6014f);
            manyPeople[1] = new Person("Nelson", 22, "Male", 65.2f, 150.6344f);
            manyPeople[2] = new Person("Neeraj", 22, "Male", 57.2f, 135.123f);
            manyPeople[3] = new Person("Raj", 22, "Male", 55.2f, 110.6014f);
            PrintDetails(manyPeople);
            Console.WriteLine(Console.BackgroundColor);
        }
        private static void PrintDetails(Person[] persons)
        {
            foreach(Person person in persons)
            {
                PrintDetails(person);
                Console.WriteLine("\nCurrent Body Structure: {0}", CheckBodyStructure(person));
            }
        }
        private static void PrintDetails(Person person)
        {
            Console.WriteLine("\nName: {0}",person.GetName());
            Console.WriteLine("Age: {0}",person.GetAge());
            Console.WriteLine("Gender: {0}",person.GetGender());
            Console.WriteLine("Height(inches): {0}",person.GetHeight());
            Console.WriteLine("Weight(lbs): {0}",person.GetWeight());
            Console.WriteLine("BMI Value: {0}",person.CalculateBMI());
        }
        private static string CheckBodyStructure(Person person)
        {
            string condition;
            if (person.CalculateBMI() < 18.5f)
            {
                condition = "Underweight";
            }
            else if (person.CalculateBMI() < 25.0f && person.CalculateBMI() > 18.4f)
            {
                condition = "Normal Healthy Weight";
            }
            else if (person.CalculateBMI() < 30.0f && person.CalculateBMI() > 24.9f)
            {
                condition = "Overweight";
            }
            else if (person.CalculateBMI() < 40.0f && person.CalculateBMI() > 29.9f)
            {
                condition = "Obese";
            }
            else if (person.CalculateBMI() >39.9f)
            {
                condition = "Morbidly obese";
            }
            else
            {
                condition = "Unknown";
            }
            return condition;
        }
    }
}

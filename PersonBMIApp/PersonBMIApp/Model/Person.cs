using System;

namespace PersonBMIApp.Model
{
    class Person
    {
        private string _name;
        private int _age;
        private string _gender;
        private float _height;
        private float _weight;

        public Person(string name,int age, string gender,float height,float weight)
        {
            _name = name;
            _age = age;
            _gender = gender;
            _height = height;
            _weight = weight;
        }

        public void Workout()
        {
            _weight = _weight - (_weight * 10) / 100;
        }

        public void Eat()
        {
            _weight = _weight + (_weight * 5) / 100;
            _height = _height + (_height * 2) / 100;
        }

        public float CalculateBMI()
        {
            float BMI=(_weight/(_height*_height))*703;
            return BMI;
        }
        
        public string GetName()
        {
            return _name;
        }
        public string GetGender()
        {
            return _gender;
        }

        public int GetAge()
        {
            return _age;
        }
        public float GetHeight()
        {
            return _height;
        }
        public float GetWeight()
        {
            return _weight;
        }
    }
}

using System;

namespace CustomerApp.Model
{
    class Customer
    {
        private string _id;
        private string _name;
        private int _credits;
        private static int idGenerator;
        static Customer()
        {
            idGenerator = 1000;
        }
        public Customer(string name):this(name,10000)
        {
        }
        public Customer(string name, int credits)
        {
            idGenerator += 1;
            _id = "C" + Convert.ToString(idGenerator);
            _name = name;
            _credits = credits;
        }
        public string ID
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Credits
        {
            get
            {
                return _credits;
            }
        }
    }
}

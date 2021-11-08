public class Person  
    {  
        private string _name = string.Empty;  
        private int _age = 0;  
   
        public string Name  
        {  
            get  
            {  
                return _name;  
            }  
        }  
   
        public int Age  
        {  
            get  
            {  
                return _age;  
            }  
            set  
            {  
                _age = value;  
            }  
        }  
    }  
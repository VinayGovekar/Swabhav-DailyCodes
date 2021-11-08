using System;
class BoxingAndUnboxing
{      
    public static void Main(string[] args)
    {
            int Number = 10;
            object BoxObject = Number;
            BoxObject = 10;
            Number = (int)BoxObject;
    }            
}


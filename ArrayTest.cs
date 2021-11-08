using System;
class ArrayTest{
    public static void Main(){
        Console.WriteLine("Enter Array Size");
        int ArrSize;
        ArrSize=int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter Values:\n");
        int[] TestArray = new int[ArrSize];
        for(int i = 0; i < ArrSize; i++){
            TestArray[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\nThis is the Array:");
        for(int j=0; j < ArrSize; j++){
            Console.WriteLine(TestArray[j]);
        }
    }
}
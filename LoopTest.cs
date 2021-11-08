using System;
class LoopTest{
    public static void Main(){
        String[] TestCharArray = {"a","b","c"};
        int EndWhile=0;
        int EndDoWhile=0;

        //While Loop
        Console.WriteLine("\nWhile Loop Output:\n");
        while(EndWhile<5){
            Console.WriteLine(EndWhile);
            EndWhile=EndWhile+1;
        }

        //Do While Loop
        Console.WriteLine("\nDo While Loop Output:\n");
        do{
            Console.WriteLine(EndDoWhile);
            EndDoWhile=EndDoWhile+1;
        }
        while(EndDoWhile<5);

        //For Each loop
        Console.WriteLine("\nFor Each Loop Output:\n");
        foreach(String Letter in TestCharArray){
            Console.WriteLine(Letter);
        }
    }
}
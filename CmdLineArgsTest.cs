using System;
class CmdLineArgsTest{
    public static void Main(String[] Names){
        Console.WriteLine("Size:");
        Console.WriteLine(Names.Length);
        if(Names.Length==0){
            Console.WriteLine("\nNo command line arguments present");
        }
        else{
            Console.WriteLine("\n Arguments are:");
            for(int i=0; i<Names.Length; i++){
                Console.WriteLine(Names[i]);
            }
        }
    }
}
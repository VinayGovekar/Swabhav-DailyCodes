using System;
class Program{
    public static void Main()
    {
        string s1 ="Vinay";
        string s2 = s1;
        s1+=" ABC";
        Console.WriteLine(s1==s2);

        s1.Replace("V","M");
        Console.WriteLine(s1);
    }
}
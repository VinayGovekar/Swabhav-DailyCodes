using System;
public class Rule1{

    public static string Board(){
        string mainString = "";
        return CollectRows(mainString);
    }
    public static string CollectRows(string displayString){
        for(int i=0;i<10;i++) displayString =AddData(displayString,i);
        return displayString;
    }
    public static string AddData(string displayString,int row){
        for(int j=0;j<10;j++) displayString=displayString + Convert.ToString(j)+Convert.ToString(row)+"\n";
        return displayString;
    }

    public static void Main(){
        Console.WriteLine(Board());
        Console.ReadLine();
    }
}
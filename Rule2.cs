using System;
class Rule2{
    public static void Main(){
        string userName = "admin";
        string password = "admin";
        Console.WriteLine(ValidateUser(userName,password));   
    }
    public static string ValidateUser(string userName,string password){
        if(userName!="admin" && password!="admin") return "Invalid";
        return "Valid";
    }
}
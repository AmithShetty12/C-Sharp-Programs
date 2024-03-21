using System;
using System.IO;

class p7{
    public static void Main(string[] args){
        Console.WriteLine("Enter Path of the Source File!");
        string source= Console.ReadLine();
        Console.WriteLine("Enter Path of the Source File!");
        string destination= Console.ReadLine();
        
        try{
            string contents = File.ReadAllText(source);

        File.WriteAllText(destination, contents);

        Console.WriteLine("DONE.........");
        Console.ReadLine();
        }
        catch(Exception ex){
            Console.WriteLine("....ERROR....");
            Console.WriteLine(ex);
        }
        
    }
}
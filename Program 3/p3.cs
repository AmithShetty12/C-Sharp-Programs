using System;
using System.Linq;

class p3{
    public static void Main(string[] args){
        Console.WriteLine("Enter the Input String: ");
        string input = Console.ReadLine();
        Console.WriteLine("The Substrings of the given input string are: ");
        SubstringList(input);
        Console.WriteLine("Enter y to Continue or Click any key to Exit...");
        string option = Console.ReadLine();
        if(option == "y"){
            Console.Clear();
            Main(args);
        }
        else{
            Environment.Exit(0);
        }
    }
    public static void SubstringList(string str){
        if(CheckNumeric(str)){
            Console.WriteLine("Invalid Input! Input String should not contain Numeric Values");
            return;
        }
        for(int i=0;i<str.Length;i++){
            for(int j=1;j<=str.Length-i;j++){
                string result= str.Substring(i, j);
                Console.WriteLine(result);
            }
        }
        
    }
    public static bool CheckNumeric(string input){
        return input.Any(char.IsDigit);
    }
}
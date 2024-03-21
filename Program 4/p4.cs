using System;

class p4{
    public static void Main(string[] args){
        try{
            int numerator = 10;
            int denominator = 0;
            int result = numerator/denominator;
            Console.WriteLine(result);
        }
        catch(DivideByZeroException ex){
            Console.WriteLine("Attempting to Divide By Zero!");
            Console.WriteLine(ex.Message);
            Console.ReadLine();
        }
        Console.WriteLine();
        try{
            int[] number = {1,2,3,4,5};
            int index = 10;
            int value = number[index];
            Console.WriteLine(value);
        }
        catch(IndexOutOfRangeException e){
            Console.WriteLine("Index is out of range!");
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }
}
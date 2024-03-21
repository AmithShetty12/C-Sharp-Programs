using System;
class p1{
    public static void Main(string[] args){
        Console.WriteLine("***Welcome to the Arithmetic Operation***");
        
        Console.WriteLine("Choose an Option");
        Console.WriteLine("'+'Addition\n'-'Subtraction\n'*'Multiplication\n'/'Division\n'%'Modulus");
        Console.WriteLine("Select any one option");
        char op= Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("Enter the First Operand:");
        double a= Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the Second Operand:");
        double b= Convert.ToDouble(Console.ReadLine());

        double result=0;

        switch(op){
            
            case '+':
                result = a+b;
                Console.WriteLine(a+" + "+b+" = "+result);

                break;
            
            case '-':
                result = a-b;
                Console.WriteLine(a+" - "+b+" = "+result);
                break;
            
            case '*':
                result = a*b;
                Console.WriteLine(a+" * "+b+" = "+result);
                break;

            case '/':
                if(b!=0){
                    result = a/b;
                    Console.WriteLine(a+" / "+b+" = "+result);
                }
                else{
                    Console.WriteLine("Cannot be Divided by Zero!");
                }
                break;

            case '%':
                if(b!=0){
                    result = a%b;
                    Console.WriteLine(a+" % "+b+" = "+result);
                }
                else{
                    Console.WriteLine("Cannot be Divided by Zero!");
                }
                break;
            
            default:
                Console.WriteLine("Invalid operator! Select a correct operator again!");
                break;

        }

        Console.WriteLine("Press y to Continue! or Press any Key to Exit!");
        string answer= Console.ReadLine();
        if(answer == "y"){
            Console.Clear();
            Main(args);
        }
        else{
            Environment.Exit(0);
        }
    }
}
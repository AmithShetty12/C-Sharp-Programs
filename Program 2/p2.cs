using System;

class p2{
    public static void Main(string[] args){
        Console.WriteLine("Enter the Maximum Limit of the Number!");
        int maxlimit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Armstrong Numbers between 1 to {0} is: ",maxlimit);
        for(int num=1; num<=maxlimit; num++){
            if(IsArmstrong(num)){
                Console.WriteLine(num);
            }
        }
        Console.WriteLine("Enter any Key to Exit!");
        Console.ReadLine();
    }
    public static bool IsArmstrong(int number){
        int originalnum = number;
        int num = 0;
        int remainder;
        int result = 0;

        while(originalnum!=0){
            originalnum =originalnum/10;
            num++;
        }
        
        originalnum = number;
        
        while(originalnum!=0){
            remainder = originalnum%10;
            result += (int) Math.Pow(remainder, num);
            originalnum = originalnum/10;
        }
        
        return number == result;
    }
}
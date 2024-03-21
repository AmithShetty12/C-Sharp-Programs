using System;
class p6{
    public static void Main(string[] args){
        int num = 1;
        Console.WriteLine("Enter the number of rows:");
        int row = Convert.ToInt32(Console.ReadLine());
        for(int i=1; i<=row; i++){
            for(int j=1;j<=i;j++){
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
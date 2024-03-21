using System;
class p6
{
 public static void Main(string[] args)
 {
   Console.WriteLine("Enter the number of rows for floyd's triangle:");
   int numrows=int.Parse(Console.ReadLine());
   int[][] triangle=new int[numrows][];
   int num=1;
   Console.WriteLine();
   for(int row=0;row<numrows;row++)
   {
    triangle[row]=new int[row+1];
    for(int col=0;col<=row;col++)
    {
     triangle[row][col]=num;
     Console.Write(triangle[row][col]+" ");
     num++;
    }
    Console.WriteLine();
   }
   Console.ReadLine();
 }
}

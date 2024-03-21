using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Number of rows");
        int numRows = Convert.ToInt32(Console.ReadLine()); 
        int[][] triangle = GeneratePascalsTriangle(numRows);

        for (int i = 0; i < numRows; i++)
        {
            for (int space = 0; space < numRows - i; space++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                Console.Write(triangle[i][j] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    static int[][] GeneratePascalsTriangle(int numRows)
    {
        int[][] triangle = new int[numRows][];

        for (int i = 0; i < numRows; i++)
        {
            triangle[i] = new int[i + 1];
            triangle[i][0] = 1;
            triangle[i][i] = 1;

            for (int j = 1; j < i; j++)
            {
                triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
            }
        }

        return triangle;
    }
}

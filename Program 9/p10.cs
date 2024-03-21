using System;

class p10{
	public static void Main(string[] args){
		Console.WriteLine("Enter number of Rows");
		int rows = Convert.ToInt32(Console.ReadLine());
		printPascalsTriangle(rows);
		Console.ReadLine();
	}
	static void printPascalsTriangle(int rows){
		for(int i=0;i<rows;i++){
			for(int j=0;j<rows-i-1;j++){
				Console.Write(" ");
			}
			for(int j=0;j<=i;j++){
				Console.Write(CalculateValue(i,j)+" ");
			}
			Console.WriteLine();
		}
	}
	static int CalculateValue(int rows, int columns){
		if(columns == 0 || columns == rows){
			return 1;
		}
		else{
			return(CalculateValue(rows-1,columns-1)+CalculateValue(rows-1,columns));
		}
	}
}
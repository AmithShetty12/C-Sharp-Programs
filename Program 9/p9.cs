using System;

class p9{
	public static void Main(string[] args){
		Console.WriteLine("Enter the Real and Imaginary of First Number");
		double real1 = Convert.ToDouble(Console.ReadLine());
		double img1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the Real and Imaginary of First Number");
		double real2= Convert.ToDouble(Console.ReadLine());
		double img2 = Convert.ToDouble(Console.ReadLine());
		
		Complex c1 = new Complex(real1, img1);
		Complex c2 = new Complex(real2, img2);
		
		Complex res = c1 + c2;
		
		Console.WriteLine(res);
		Console.ReadLine();
	}
}

public struct Complex{
	public double real;
	public double imaginary;
	public Complex(double real, double imaginary){
		this.real=real;
		this.imaginary=imaginary;
	}
	public static Complex operator +(Complex one, Complex two){
		return new Complex(one.real+ two.real, one.imaginary+ two.imaginary);
	}
	public override string ToString(){
		return(String.Format(" {0} + {1}i ",real,imaginary));
	}
}
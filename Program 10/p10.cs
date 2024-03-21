using System;
public class Shape{
	public virtual void draw(){
		Console.WriteLine("Drawing Shape");
	}
	public virtual void erase(){
		Console.WriteLine("Erasing Shape");
	}
}
public class Square : Shape{
	public override void draw(){
		Console.WriteLine("Drawing Square");
	}
	public override void erase(){
		Console.WriteLine("Erasing Square");
	}
}
public class Triangle : Shape{
	public override void draw(){
		Console.WriteLine("Drawing Triangle");
	}
	public override void erase(){
		Console.WriteLine("Erasing Triangle");
	}
}
public class Circle : Shape{
	public override void draw(){
		Console.WriteLine("Drawing Circle");
	}
	public override void erase(){
		Console.WriteLine("Erasing Circle");
	}
}

class p10{
	public static void Main(string[] args){
		Shape[] shapes = new Shape[3];
		shapes[0] = new Square();
		shapes[1] = new Triangle();
		shapes[2] = new Circle();
		foreach(Shape shape in shapes){
			shape.draw();
			shape.erase();
		}
		Console.ReadLine();


	}
}
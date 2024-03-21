using System;
public abstract class Shape
{
    public abstract double GetPerimeter();
    public abstract double GetArea();
}
public class Circle : Shape
{
    private double radius;
    private readonly double pi = Math.PI;public Circle()
    {
        this.radius = 1;
    }
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double GetArea()
    {
        return pi * Math.Pow(radius, 2);
    }
    public override double GetPerimeter()
    {
        return 2 * pi * radius;
    }
}
public class Triangle : Shape
{
    private double width, height;public Triangle()
    {
        this.width = 1;
        this.height = 1;
    }
    public Triangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public override double GetArea()
    {
        return width * height;
    }
    public override double GetPerimeter()
    {
        return width + height + Math.Sqrt(Math.Pow(width, 2) +Math.Pow(height, 2));
    }
}

public class p11
{
    public static void Main(string[] args)
    {
        double width = 13, length = 9;
        Shape triangle = new Triangle(width, length);

        Console.WriteLine("The width of the triangle is: " + width);
        Console.WriteLine("The height of the triangle is: " + length);
        Console.WriteLine("The area of the triangle is: " +
        triangle.GetArea());
        Console.WriteLine("The perimeter of the triangle is: " +
        triangle.GetPerimeter());


        double radius = 3;
        Shape circle = new Circle(radius);

        Console.WriteLine();
        Console.WriteLine("The radius of the circle is: " + radius);
        Console.WriteLine("The area of the circle is: " + circle.GetArea());
        Console.WriteLine("The perimeter of the circle is: " +
        circle.GetPerimeter());

        Console.ReadLine();
    }
}
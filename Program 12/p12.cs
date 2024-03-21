using System;

public interface IResizable{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

public class Rectangle : IResizable{
    private int width;
    private int height;
    
    public Rectangle(int width, int height){
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(int width){
        this.width = width;
    }

    public void ResizeHeight(int height){
        this.height = height;
    }

    public void PrintSize(){
        Console.WriteLine("Width: " + width + ", Height: " + height);
    }
}


public class Program12{
    public static void Main(string[] args){
        Rectangle rectangle = new Rectangle(100, 150);
        rectangle.PrintSize();
        rectangle.ResizeWidth(150);
        rectangle.ResizeHeight(200);
        rectangle.PrintSize();

        Console.ReadLine();
    }
}
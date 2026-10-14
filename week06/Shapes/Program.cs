using System;
using System.Collections.Generic;

class Program
{
    public static List<Shape> shapes = new List<Shape>();
    public static int Main(string[] args)
    {
        Square square = new Square("Red", 5.0f);
        Rectangle rectangle = new Rectangle("Green", 4.0f, 6.0f);
        Circle circle = new Circle("Blue", 3.0f);
        
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
        return 0;
    }
}

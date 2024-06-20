using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new();
        shapes.Add(new Rectangle("blue", 4, 5));
        shapes.Add(new Circle("green", 6));
        shapes.Add(new Square("purple", 3));
        
        foreach (Shape shape in shapes){
            Console.WriteLine($"The {shape.getColor()} shape has an area of {shape.getArea()}");
        }
    }
}
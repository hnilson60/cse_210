using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square s1 = new Square("tart", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("crimson", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("scarlet", 6);
        shapes.Add(s3);

        triangle s4 = new triangle("carmine", 4, 8);
        shapes.Add(s4);

        foreach (Shape s in shapes)
        {
        
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"here is the {color} {s.GetType().Name} which has an area of {area}.");
        }
    }
}
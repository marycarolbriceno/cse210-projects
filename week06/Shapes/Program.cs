using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> list = new List<Shape>();

        Square square = new Square("Blue", 2);
        list.Add(square);

        Circle circle = new Circle("Black", 8);
        list.Add(circle);

        Rectangle rectangle = new Rectangle("Pink", 2, 4);
        list.Add(rectangle);

        foreach(Shape s in list)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}
public class Circle : Shape
{
    // attribute
    private double _radius;

     // constructor
    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI *_radius * _radius;
    }
}
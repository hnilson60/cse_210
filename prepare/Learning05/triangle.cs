public class triangle : Shape
{
    private double _height;
    private double _base;

    public triangle(string color, double height, double baseLength) : base (color)
    {
        _height = height;
        _base = baseLength;
    }

    // Notice the use of the override keyword here
    public override double GetArea()
    {
        return 0.5 * _base * _height;
    }
}
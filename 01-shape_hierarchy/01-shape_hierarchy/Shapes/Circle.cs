namespace _01_shape_hierarchy.Shapes;

public class Circle : Shape
{
    private double Radius { get; set; }
    public Circle(double radius)
    {
        Name = this.GetType().Name;
        Radius = radius;
    }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
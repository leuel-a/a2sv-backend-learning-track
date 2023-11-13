namespace _01_shape_hierarchy.Shapes;

public class Triangle : Shape
{
    private double Base { get; set; }
    private double Height { get; set; }

    public Triangle(double triangleBase, double height)
    {
        Name = this.GetType().Name;
        Base = triangleBase;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Base * Height * 0.5;
    }
}
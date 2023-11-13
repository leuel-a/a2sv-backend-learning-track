namespace _01_shape_hierarchy.Shapes;

public class Rectangle: Shape
{
    private double Width { get; set; }
    private double Height { get; set; }
    
    public Rectangle(double height, double width)
    {
        Name = this.GetType().Name;
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Height * Width;
    }
}
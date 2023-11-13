namespace _01_shape_hierarchy.Shapes;

public class Shape
{
    public string? Name;
    public string Id { get; private set; }

    public Shape()
    {
        Id = Guid.NewGuid().ToString();
    }
    
    public virtual double CalculateArea() => 0;
}
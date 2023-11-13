using System;
using _01_shape_hierarchy.Shapes;

namespace _01_shape_hierarchy
{
    class Program
    {
        public static void Main(string[] args)
        {
            Circle circle = new(10);
            Rectangle rectangle = new(10, 10);
            Triangle triangle = new(10, 10);

            PrintShapeArea(circle);
            PrintShapeArea(rectangle);
            PrintShapeArea(triangle);
        }

        private static void PrintShapeArea(Shape shape)
        {
            Console.WriteLine($"Shape {shape.Name}.{shape.Id} has area of {shape.CalculateArea()}");
        }
    }
}
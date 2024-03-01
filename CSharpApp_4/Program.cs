namespace CSharpApp_4
{
    internal class Program
    {
        static void Main()
        {
            Shape[] shapes = new Shape[]
            {
            new Rectangle(5, 10),
            new Circle(5),
            new RightTriangle(3, 4),
            new Trapezoid(5, 8, 6)
            };

            foreach (Shape shape in shapes)
            {
                string shapeName = shape.GetType().Name;
                double area = shape.CalculateArea();
                Console.WriteLine($"Area of {shapeName}: {area}");
            }
        }
    }
}

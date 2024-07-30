namespace Task16._1
{
    internal class Program
    {
        // Basic Interface Implementation:
        static void Main(string[] args)
        {
            IShape circle = new Circle(3.6);
            IShape rect = new Rectangle(4.9, 5);           
            IShape trgl = new Triangle(7.4, 4.1);
         
            Console.WriteLine("The area of Circle - " + circle.CalculateArea());
            Console.WriteLine("The area of Rectangle - " + rect.CalculateArea());
            Console.WriteLine("The area of Triangle - " + trgl.CalculateArea());
        }
    }
    interface IShape
    {
        public double CalculateArea();
    }
    class Circle : IShape
    {
       
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public  double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

    }
    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double CalculateArea()
        {
            return (Width * Height);
        }

    }
    class Triangle : IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
        public double CalculateArea()
        {
            return (Height * Base)/2;
        }
    }
}

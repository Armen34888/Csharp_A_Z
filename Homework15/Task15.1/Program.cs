using System.Reflection;


namespace Task15._1
{
    // Create an abstract class called Shape:
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Rectangle rectangle = new Rectangle(8.6, 5);
            circle.CalculateArea();
            rectangle.CalculateArea();
            Console.WriteLine("Area of the Circle" + circle.CalculateArea());
            Console.WriteLine("Area of the Reactangle - " + rectangle.CalculateArea());
        }
    }
    abstract class Shape
    {
        public abstract double CalculateArea();
           
    }
    class Circle : Shape
    {
        public double Radius {  get; set; }

        public Circle(double radius) 
        { 
            Radius = radius;
        }
        public override double CalculateArea() 
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

          
}

    
   
    


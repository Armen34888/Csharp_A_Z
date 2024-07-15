namespace Task13._6
{
    // Overload Operators:

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X= x;
            Y = y;
        }
        public static Point operator + (Point p1, Point p2) 
        {
           return new Point(p1.X + p2.X, p1.Y + p2.Y);  
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           Point p1 = new Point(2,6);
           Point p2 = new Point(8,4);
           Point sum = p1 + p2;
           Console.WriteLine($"p1 = {p2}");
           Console.WriteLine($"p2 = {p2}");
           Console.WriteLine($"sum = {sum}");
        }
    }
}

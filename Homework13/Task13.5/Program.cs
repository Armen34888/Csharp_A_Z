namespace Task13._5
{
    // Immutable Struct:

    public readonly struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
           X = x;
           Y = y;
           
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p = new Point(2,6);
            Point p1 = new Point(4,8);
            Console.WriteLine($"Point 1 coordinats: X = {p.X}, Y = {p.Y}");
            Console.WriteLine($"Point 2 coordinats: X = {p1.X}, Y = {p1.Y}");
        }
    }
}

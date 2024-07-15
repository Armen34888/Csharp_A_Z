namespace Task13._9
{
    // Rectangle Struct:

    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public struct Rectangle()
    {
        public int Width;
        public int Height;
        public Point TopLeftCorner;

        

        public int CalculateArea()
        {
            return Width * Height;
        }
        public int CalculatePerimetr()
        {
            return 2 * (Width + Height);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
          Point topLeft = new Point(1,1);
          
          
        }
    }
}

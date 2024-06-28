namespace Task6._16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Determine the Smallest of Four Numbers.

            int x = 426;
            int y = 4342;
            int z = 50;
            int w = 109;
            int min = x;
            if (y < min)
            {
                min = y;
            }
            if (z < min)
            {
                min = z;
            }
            if (w < min)
            {
                min = w;
            }
            Console.WriteLine("The min number is - " + min);
            
        }
    }
}

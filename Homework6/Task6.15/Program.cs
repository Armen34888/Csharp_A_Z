namespace Task6._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determine the Largest of Four Numbers.

            int a = -645;
            int b = 12456;
            int c = 638;
            int d = 4256;
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                c = max;
            }
            if (d > max)
            {
                d = max;
            }
            Console.WriteLine("The max nuber is - ");
        }
    }
}

namespace Task6._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determine the Largest and Smallest of Five Numbers.
            int a = 254;
            int b = 264;
            int c = 380000;
            int d = 12624;
            int e = 18;
            int max = a;
           
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if (d > max)
            {
                max = d;
            }
            if (e > max)
            {
                max = e;
            }
            int min = a;

            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            if (d < min)
            {
                min = d;
            }
            if (e < min)
            {
                min = e;
            }

            Console.WriteLine("The min number is - " + min);
            Console.WriteLine("The max number is - " + max);
           
        }
    }
}

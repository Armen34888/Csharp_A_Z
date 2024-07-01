namespace Task12._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rekursia: Fibonacci

            int n = 12;
            int res = Fibonacci(n);

            Console.WriteLine($"Fibonacci({n}) = {res}");

        }
        public static int Fibonacci(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci (n - 2);
            }
        }
    }
}

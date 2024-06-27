namespace Task7._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prime Numbers.

            Console.Write("Enter min diapazon - ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter max diapazon - ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime numbers from {start} before {end} - ");

            for (int i = start; i <= end; i++)
            {
                if (i > 1)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.Write($"{i} ");
                    }
                }
            }
            Console.WriteLine();

        }
    }
}

namespace Task7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find Factorial
            Console.Write("Enter number of factorial - ");
            int factorial = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 1; i <= factorial; i++)
            {
                sum *=i;
            }
            Console.WriteLine($"{factorial}-i faktorial@ klini {sum}");
        }
    }
}

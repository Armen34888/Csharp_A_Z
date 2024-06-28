namespace Task7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci Sequence
            Console.Write("Enterr number Fibonacci - ");
            int first = 0;
            int second = 1;
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{first} {second}");
            for (int i = 0; i < n; i++)
            {
                int next = first + second;
                Console.Write($" {next}");
                first = second;   
                second = next;

            }
            Console.WriteLine();
        }
    }
}

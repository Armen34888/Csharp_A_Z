namespace Task7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Multiplication Table.

            for (int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

namespace Tak7._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Print patterns using nested loops.

            int rows = 5;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}  

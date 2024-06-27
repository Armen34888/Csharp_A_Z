using System.Collections.Generic;

namespace Task7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of First N Natural Numbers.

            Console.Write("Enter number - ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
           
            for (int i = 0; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum of Natural numbers - " + sum);

        }
    }
}

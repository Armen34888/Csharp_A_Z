namespace Task8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Average of Numbers
            Console.WriteLine("Enter 50 numbers");
            int total = 50;
            int sum = 0;
            for (int i = 1; i < 50; i++)
            {
               int x = Convert.ToInt32(Console.ReadLine());
                sum += x;
                if (i == 20)
                {
                    Console.WriteLine("Mnac 30 hat");
                }
                if (i == 40)
                {
                    Console.WriteLine("Mnac 10 hat");
                }
            }
            int res = sum / total;
            Console.Write("50 hat tvi mijin@ klini - " + res);

        }
    }
}

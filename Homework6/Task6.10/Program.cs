namespace Task6._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Nested if with Multiple Conditions.
            int a = 3289;
            int b = 4242787;
            int c = 162485;
            int max = a;
            if (b > a) 
            {
                max = b;
            }
            if (c > a)
            {
                max = c;
            }
            Console.WriteLine("The max number is - " +max);
        }
    }
}

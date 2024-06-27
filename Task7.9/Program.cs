namespace Task7._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int sum = 0;
            int r = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum += r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();

        }
    }
}

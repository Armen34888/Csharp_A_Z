namespace Task8._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Armstrong Number.
            Console.Write("Enter number - ");
            int num = int.Parse(Console.ReadLine());

            int originalNumber = num;
            int numDigits = 0;
            int sum = 0;

            while (num != 0)
            {
                num /= 10;
                numDigits++;
            }

            num = originalNumber;

            while (num != 0)
            {
                int digit = num % 10;
                sum += (int)Math.Pow(digit, numDigits);
                num /= 10;
            }

            if (sum == originalNumber)
            {
                Console.WriteLine($"{originalNumber} -@ Armstrogi tiv e");
            }
            else
            {
                Console.WriteLine($"{originalNumber} -@ Armstrongi tiv che");
            }
        }
    }
}

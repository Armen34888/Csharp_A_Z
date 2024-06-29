namespace Task8._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of Even Digits.
            Console.Write("Enter number - ");
            int number = int.Parse(Console.ReadLine());

            int sumOfEvenDigits = 0;
            int digit;

          
            while (number != 0)
            {
                digit = number % 10; 
                number /= 10; 

                
                if (digit % 2 == 0)
                {
                    sumOfEvenDigits += digit; 
                }
            }

            Console.WriteLine($"Zuyg tveri gumar@ klini  {sumOfEvenDigits}");
        }
    }
}

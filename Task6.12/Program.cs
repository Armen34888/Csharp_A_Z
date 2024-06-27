namespace Task6._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Determine if a Number is Positive, Negative, or Zero.

            int num = -248;
            if (num == 0)
            {
                Console.WriteLine("The number is 0");
            }
            else if (num >= 1)
            {
                Console.WriteLine("The number is pozitive");
            }
            else
            {
                Console.WriteLine("The number is negative");
            }

        }
    }
}

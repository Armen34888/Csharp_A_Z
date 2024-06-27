namespace Task6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If with Logical Operators.

            int temp = 26;
            bool isRaining = false;
            if ( temp > 20 &&  !isRaining ) 
            {
                Console.WriteLine("Good weather for a walk.");
            }
            else
            {
                Console.WriteLine("Stay indoors");
            }
        }
    }
}

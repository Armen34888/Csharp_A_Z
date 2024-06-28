namespace Task6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // If-else if-else Ladder.

            int x = 76;
            if ( x >= 90 )
            {
                Console.WriteLine("A");
            }
            else if ( x >= 80)
            {
                Console.WriteLine("B");
            }
            else if( x >= 70)
            {
                Console.WriteLine("C");
            }
            else if (x >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("E");
            }
        }
    }
}

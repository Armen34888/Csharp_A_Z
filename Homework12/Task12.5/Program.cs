using System.Reflection.Metadata.Ecma335;

namespace Task12._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reverse String with :

            string str = "Hello world";
            Console.WriteLine($"Original string: {str}");

            string reverse = ReverseString(str);
            Console.WriteLine($"Reverse string: {reverse}");


            
        }
        static string ReverseString(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse( array );
            return new string(array);
        }
    }
}

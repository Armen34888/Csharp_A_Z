using System.Security.Cryptography;

namespace Task8._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generate Random Numbers

            Random random = new Random();
            Console.WriteLine("1-ic 100 patahakan 10 tvern en");
            for (int i = 0; i < 10; i++)
            {
              int randomnumber = random.Next(10,100);
                Console.WriteLine(randomnumber);
            }
        }
    }
}

using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace Task18._1
{
    internal class Program
    {
        // Custom Range Generator:
        static void Main(string[] args)
        {
            var x = RangeGenerator(5, 10);
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }

        }
        public  static IEnumerable RangeGenerator(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                yield return i;
            }
        }

    }
}

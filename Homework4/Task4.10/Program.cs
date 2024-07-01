namespace Task4._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GetHashCode

            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";
            Console.WriteLine(str1.GetHashCode());
            Console.WriteLine(str2.GetHashCode());
            Console.WriteLine(str3.GetHashCode());
        }
    }
}

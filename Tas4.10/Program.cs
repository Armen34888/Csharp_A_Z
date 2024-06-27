namespace Tas4._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GetHashCode
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";
            int res = str1.GetHashCode();
            int res1 = str2.GetHashCode();
            int res2 = str3.GetHashCode();
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
        }
    }
}

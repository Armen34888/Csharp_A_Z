namespace Task4._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // == Operator
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";
            bool res = (str1 == str2);
            bool res1 = (str1 == str3);
            Console.WriteLine(res);
            Console.WriteLine(res1);
        }
    }
}

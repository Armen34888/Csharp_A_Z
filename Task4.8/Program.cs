namespace Task4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Checking for Null or Empty Strings
            string str = "Hello World";
            string str1 = "";
            bool res = string.IsNullOrEmpty(str);
            bool res1 = string.IsNullOrEmpty(str1);
            Console.WriteLine(res);
            Console.WriteLine(res1);

            string str2 = "          ";
            string str3 = "        Hello";
            bool res2 = string.IsNullOrWhiteSpace(str2);
            bool res3 = string.IsNullOrWhiteSpace(str3);
            Console.WriteLine(res2);
            Console.WriteLine(res3);

        }
    }
}

namespace Task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String Concatenation
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "!";
            string res = string.Concat(str1," " ,str2,  str3);
            Console.WriteLine(res);
        }
    }
}

namespace Task4._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Equals

            string str1 = "hello";
            string str2 = "hello";
            string str3 = "world";
            bool res =Equals(str1, str2);
            bool res1 =Equals(str1, str3);
            Console.WriteLine(res);
            Console.WriteLine(res1);
        }
    }
}

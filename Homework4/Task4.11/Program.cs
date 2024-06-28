namespace Task4._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reference Equals

            string str1 = "TTT";
            string str2 = "TTT";
            string str3 = "TTT,3";
            bool res = ReferenceEquals(str1, str2);
            bool res1 = ReferenceEquals(str1, str3);
            Console.WriteLine(res);
            Console.WriteLine(res1);


        }
    }
}

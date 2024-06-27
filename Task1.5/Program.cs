namespace Task1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "3658";
            int a =int.Parse(str);
            Console.WriteLine(a);

            int b = 456;
            double c = (double)b;
            Console.WriteLine(c);

            double x = 38.9;
            int y = (int)x;
            Console.WriteLine(y);

            int z = 65;                 
            char ch = (char)z;        // ASCII
            Console.WriteLine(ch);
        }
    }
}

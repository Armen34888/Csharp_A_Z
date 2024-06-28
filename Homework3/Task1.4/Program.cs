namespace Task1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using int.Parse and int.TryParse
            string str = "236";
            int x = int.Parse(str);
            Console.WriteLine(x);

            string str1 = "Hello world";
            int y;
            bool tryParse = int.TryParse(str1, out y);
           
            Console.WriteLine(str1);
            
        }
    }
}

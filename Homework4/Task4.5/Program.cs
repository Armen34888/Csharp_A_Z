namespace Task4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Splitting Strings
            string fruits = "apple,banana,orange";
            string[] res = fruits.Split(',');
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.WriteLine(res[2]);
        }
    }
}

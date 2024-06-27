namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age - ");
            int age = int.Parse(Console.ReadLine());
            int now = 2024;
            int born = now - age;
            Console.WriteLine("You are born in  " +  born);
        }
    }
}

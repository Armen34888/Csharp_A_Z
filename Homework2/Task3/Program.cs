namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int now = 2024;
            Console.Write("Enter born year - ");
            int born = int.Parse(Console.ReadLine());
            int age = now - born;
            Console.WriteLine("Your age is - " + age);
        }
    }
}

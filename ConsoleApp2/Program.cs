namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name - ");
            string name = Console.ReadLine();
            Console.Write("Enter surname - ");
            string surname = Console.ReadLine();
            Console.Write("Enter age - ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter profession - ");
            string profession = Console.ReadLine();
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Surname - " + surname);
            Console.WriteLine("Age - " + age);
            Console.WriteLine("Profession - " +  profession);

        }
    }
}

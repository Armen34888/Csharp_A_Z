namespace Task2
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
            
            Console.Write("Name - " + name);
            Console.Write(" , ");
            Console.Write("Surname - " + surname);
            Console.Write(" , ");
            Console.Write("Age - " + age);
            Console.Write(" , ");
            Console.Write("Profession - " + profession);
            Console.Write(" , ");
        }
    }
}

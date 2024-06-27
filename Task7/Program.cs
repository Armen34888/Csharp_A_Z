namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Title " + Console.Title);
           
            Console.Title = "New Title"; 
            Console.WriteLine("Current is changed - " + Console.Title);
            Console.ReadLine(); 
        }
    }
}

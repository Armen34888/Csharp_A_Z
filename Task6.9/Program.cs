namespace Task6._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch with Fall-through.

            int level = 2;
            switch (level)
            {
                case 1:
                    Console.WriteLine("Level 1: Beginner");
                    goto case 2;
                case 2:
                    Console.WriteLine("Level 2: Intermediate");
                    goto case 3;
                case 3:
                    Console.WriteLine("Level 3: Advanced");
                    break;
                default:
                    Console.WriteLine("Invalid level");
                    break ;
            }
        }
    }
}

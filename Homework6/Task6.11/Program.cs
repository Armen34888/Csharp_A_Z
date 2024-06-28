namespace Task6._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Combining if-else and switch.

            int menuOption = 3;
            if (menuOption >= 1 && menuOption <= 3)
            {
                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("Start Game");
                        break;
                    case 2:
                        Console.WriteLine("Load Game");
                        break;
                    case 3:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid menu option");
                        break;
                          
                }
            }
        }
    }
}

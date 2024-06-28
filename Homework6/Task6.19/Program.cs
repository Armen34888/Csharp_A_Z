namespace Task6._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check If a Character is a Vowel or Consonant.
            char ch = 'd';
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i':
                    Console.WriteLine($"{ch}-n dzaynavor e");
                    break;
                default:
                    Console.WriteLine($"{ch}-n baxadzayn e");
                    break;

            }
        }
    }
}

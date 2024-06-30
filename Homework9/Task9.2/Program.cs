namespace Task9._2
{
    internal class Program
    {
        // Language Translation Enum.
        enum Language
        {
            English,
            Spanish,
            French
        }
        static void Main(string[] args)
        {
            string wordtotranslate = "apple";
            Language language = Language.Spanish;
            switch (language)
            {
                case Language.Spanish:
                    Console.WriteLine("manzana");
                    break;
                case Language.French:
                    Console.WriteLine("pomme");
                    break;
                case Language.English:
                    Console.WriteLine("apple");
                    break;
                default:
                    Console.WriteLine("Invalid word");
                    break;
            }

        }
    }
}

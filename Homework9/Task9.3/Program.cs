namespace Task9._3
{
    internal class Program
    {
        // Custom Enum Properties.
        enum Language
        {
            English,
            Spanish,
            French,
            Armenian,
            Russian
        }
        static void Main(string[] args)
        {
           Language language = Language.English;
            string isoCode = GetISOCode(language);
            Console.WriteLine($"ISO code of the {language} {isoCode}");
        }
         static string GetISOCode(Language language) 
        { 
            switch (language)
            {
                case Language.English:
                    return "en";
                case Language.Spanish:
                    return "es";
                case Language.French:
                    return "fr";
                default:
                    return "Unknown";
            }
        }
    }
}

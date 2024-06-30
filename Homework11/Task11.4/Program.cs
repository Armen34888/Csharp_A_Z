namespace Task11._4
{
    internal class Program
    {
        //Check If a Flag Is Set:
        [Flags]
         enum FontStyles
        {
            None = 0,       // No styles
            Bold = 1 << 0,  // Bold style: 1
            Italic = 1 << 1,  // Italic style: 2
            Underline = 1 << 2  // Underline style: 4
        }
        static void Main(string[] args)
        {
            
            FontStyles myFont = FontStyles.Bold | FontStyles.Italic;

            if ((myFont & FontStyles.Bold) != 0)
            {
                Console.WriteLine("Bold style is set.");
            }
            else
            {
                Console.WriteLine("Bold style is not set.");
            }

            if ((myFont & FontStyles.Underline) != 0)
            {
                Console.WriteLine("Underline style is set.");
            }
            else
            {
                Console.WriteLine("Underline style is not set.");
            }
        }
    }
}

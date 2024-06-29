namespace Task8._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count Words in a Sentence.
            Console.Write("Enter Sentence - ");
            string sentence = Console.ReadLine().Trim(); 

            int wordCount = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                
                if (sentence[i] != ' ' &&  (i == 0 || sentence[i - 1] == ' '))
                {
                    wordCount++;
                }
            }

            Console.WriteLine($"Naxadasutyan mej ka {wordCount} bar");
        }
    }
}

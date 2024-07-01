namespace Task12._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Split String In to Words:

            string sentence = "Hello, this is a sample sentence.";

            string[] words = SplitStringIntoWords(sentence);

            Console.WriteLine($"Original sentence: {sentence}");
            Console.WriteLine("Words:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            static string[] SplitStringIntoWords(string sentence)
            {
                // Split the sentence into words based on whitespace and punctuation
                string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                return words;
            }
        }
    }
}

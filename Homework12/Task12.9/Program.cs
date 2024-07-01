namespace Task12._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Anagram functions:

            string str1 = "listen";
            string str2 = "silent";

            bool areAnagrams = CheckAnagrams(str1, str2);

            Console.WriteLine($"Are '{str1}' and '{str2}' anagrams? {areAnagrams}");
        }
        static bool CheckAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();

            Array.Sort(charArray1);
            Array.Sort(charArray2);

            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}

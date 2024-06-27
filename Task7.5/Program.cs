namespace Task7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count Vowels in a String.

            Console.Write("Enter string - ");
            string str = Console.ReadLine();
            int dzaynavor = 0;
            int baxadzayn = 0;
           
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    dzaynavor++;
                }
                else if (str[i] != 'a' || str[i] != 'e' || str[i] != 'i' || str[i] != 'o' || str[i] != 'u')
                {
                    baxadzayn++;
                }

            }
            Console.WriteLine("Dzaynavor - " + dzaynavor);
            Console.WriteLine("Baxadzayn - " + baxadzayn);
        }
    }
}

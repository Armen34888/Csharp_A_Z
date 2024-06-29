namespace Task8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Check Palindrome.
            Console.Write("Enter name - ");
            string name = Console.ReadLine();
            int left = 0;
            int right = name.Length - 1;
            bool palindrom = true;
            while (left < right)
            {
                if (name[left] != name[right])
                {
                    palindrom = false;
                }
                left++;
                right--;
            }
            if (palindrom)
            {
                Console.WriteLine($"The {name} is palindrom");
            }
            else
            {
                Console.WriteLine($"{name} is not palindrom");
            }
        }
    }
}

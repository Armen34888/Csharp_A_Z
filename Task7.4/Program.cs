namespace Task7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reverse a String.

            Console.Write("Enter string - ");
            string name = Console.ReadLine();
            string reverse = "";
            for (int i = name.Length - 1; i >= 0; i--) 
            {
                reverse += name[i];
            }
            Console.WriteLine(reverse);
          
          
          


        }
    }
}

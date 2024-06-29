namespace Task8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Count Occurrences of a Character.
            Console.Write("Enter string - ");
            string name = Console.ReadLine();
            Console.Write("Enter char - ");
            char ch = Convert.ToChar(Console.ReadLine());
            int qanak = 0;
            foreach(char c in name)
            {
                if(c == ch)
                {
                    qanak++;
                }
            }
            Console.WriteLine($"{ch}-n handipum e {qanak } angam");
            
        }
    }
}

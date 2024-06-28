namespace Task4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Searching Within Strings

            string text = "Es im anush Hayastani  arevaham barn em sirum";
            bool word = text.Contains("im");
            Console.WriteLine(word);
            Console.WriteLine(text.Length);
            int index = text.IndexOf("im");
            Console.WriteLine(index);
                            
                        
                           
                
                          
          
        }
    }
}


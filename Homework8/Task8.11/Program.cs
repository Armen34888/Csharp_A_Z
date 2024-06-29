namespace Task8._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rock, Paper, Scissors Game.

            Random random = new Random();

            string[] options = { "tuxt, mkrat, qar" };
          
            string comp = options[random.Next(0,options.Length)];
            Console.WriteLine("@ntreq dzer tarberak@ - qar, tuxt te mkrat");

            string user = Console.ReadLine();
            Console.WriteLine($"Duq @ntreciq {user}");
            Console.WriteLine($"Compn @ntrec {comp}");
            
            if ( comp == user )
            {
                Console.WriteLine("Voch voqi");
            }
            else if (( user == "qar" &&  comp == "mkrat") || ( user == "mkrat" &&  comp == "tuxt") || 
                    ( user == "tuxt" && comp == "qar"))
            {
                Console.WriteLine("Duq haxteciq");
            }
            else
            {
                Console.WriteLine("Comp@ haxtec");
            }

            


        }
    }
}

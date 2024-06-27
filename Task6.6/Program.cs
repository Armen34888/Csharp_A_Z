namespace Task6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch Statement with Strings.

            string command = "stop";
            switch (command)
            {
                case "start":
                    Console.WriteLine("Start");
                    break;
                case "stop":
                    Console.WriteLine("Stop");
                    break;
                case "pause":
                    Console.WriteLine("Pause");
                    break;
                case "resume":
                    Console.WriteLine("resume");
                    break;
            }
        }
    }
}

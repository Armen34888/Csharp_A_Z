namespace Task8._9
{
    internal class Program
    {
        // File Extensions Enum.
        enum FileExtensions
        {
            txt,
            jpg,
            pdf
        }
        static void Main(string[] args)
        {
           FileExtensions fileExtensions = FileExtensions.txt;
            switch (fileExtensions)
            {
                case FileExtensions.txt:
                    Console.WriteLine("The file is valid");
                    break;
                case FileExtensions.jpg:
                    Console.WriteLine("The file is valid");
                    break;
                case FileExtensions.pdf:
                    Console.WriteLine("The file is falid");
                    break;
                default:
                    Console.WriteLine("Invalid file");
                    break;
            }

           
        

        }
    }
}

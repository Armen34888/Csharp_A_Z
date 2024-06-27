namespace Task6._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grade Categorization

            int grade = 16;
            if (grade > 0 && grade <= 8)
            {
                Console.WriteLine("Fail");
            }
            else if (grade > 8 && grade <= 12)
            {
                Console.WriteLine("Pool");
            }
            else if (grade > 12 && grade <= 16)
            {
                Console.WriteLine("Average");
            }
            else if (grade > 16 && grade <= 18)
            {
                Console.WriteLine("Good");
            }
            else if(grade > 18 && grade <= 20)
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                Console.WriteLine("Unknown grade");
            }
        }
    }
}

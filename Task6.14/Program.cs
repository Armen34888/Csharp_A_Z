namespace Task6._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Age Group Classification.

            int age = 36;
            if (age > 0 && age <= 14)
            {
                Console.WriteLine("Child");
            }
            else if (age > 14 && age <= 25)
            {
                Console.WriteLine("Teenager");
            }
            else if (age > 25 && age <= 60)
            {
                Console.WriteLine("Adult");
            }
            else if(age > 60 && age <= 90)
            {
                Console.WriteLine("Senior");
            }
            else
            {
                Console.WriteLine("Age");
            }
        }
    }
}

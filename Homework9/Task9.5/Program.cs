namespace Task9._5
{
    internal class Program
    {
        // Weekdays Enum.
        enum WeekDays
        {
            Monday,
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
           WeekDays weekDays = WeekDays.Saturday;
            switch (weekDays)
            {
                case WeekDays.Monday:
                    Console.WriteLine("Working day");
                    break;
                case WeekDays.Tuesday:
                    Console.WriteLine("Working day");
                    break;
                case WeekDays.Wednesday:
                    Console.WriteLine("Working day");
                    break;
                case WeekDays.Thursday:
                    Console.WriteLine("Working day");
                    break;
                case WeekDays.Friday:
                    Console.WriteLine("Working day");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine("Weekend day");
                    break;
                case WeekDays.Sunday:
                    Console.WriteLine("Weekend day");
                    break;
                
            }
        }
    }
}

namespace Task11._6
{
    internal class Program
    {
        //Weekend Days Combination:
        [Flags]
        enum DaysOfWeek
        {
            None = 0,
            Monday = 1 << 0,    // 1
            Tuesday = 1 << 1,   // 2
            Wednesday = 1 << 2, // 4
            Thursday = 1 << 3,  // 8
            Friday = 1 << 4,    // 16
            Saturday = 1 << 5,  // 32
            Sunday = 1 << 6,    // 64

            Weekend = Saturday | Sunday
        }
        static void Main(string[] args)
        {
            // Calculate the weekend days using bitwise OR
            DaysOfWeek weekend = DaysOfWeek.Saturday | DaysOfWeek.Sunday;

            // Print out the weekend days
            Console.WriteLine("Weekend days: " + weekend);

            // Check if Saturday is part of the weekend
            if ((weekend & DaysOfWeek.Saturday) != 0)
            {
                Console.WriteLine("Saturday is part of the weekend.");
            }

            // Check if Friday is part of the weekend (it shouldn't be)
            if ((weekend & DaysOfWeek.Friday) != 0)
            {
                Console.WriteLine("Friday is part of the weekend.");
            }
            else
            {
                Console.WriteLine("Friday is not part of the weekend.");
            }
        }
    }
}

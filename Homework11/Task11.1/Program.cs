namespace Task11._1
{
    internal class Program
    {
        // Set Bit Using Bitwise OR:
        [Flags]
        enum DaysOfWeek
        {
            None = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 4,
            Thursday = 8,
            Friday = 16,
            Saturday = 32,
            Sunday = 64,
        }

        static void Main(string[] args)
        {
            DaysOfWeek daysOfWeek = DaysOfWeek.None;
            daysOfWeek |= DaysOfWeek.Tuesday;
            Console.WriteLine(daysOfWeek);
                
        }
    }
}

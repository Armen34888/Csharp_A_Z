namespace Task10._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Frequency of Each Element:
            int[] nums = { 25, 12, 43 };
            Console.WriteLine("Frequency of all elements of the array: ");
            if ((nums[0] != nums[1]) && (nums[0] != nums[2]))
            {
                Console.WriteLine("25 occurs 1 time.");
            }
            else
            {
                Console.WriteLine("25 occurs many time.");
            }
            if ((nums[1] != nums[0]) && (nums[1] != nums[2]))
            {
                Console.WriteLine("12 occurs 1 time.");
            }
            else
            {
                Console.WriteLine("12 occurs many time.");
            }
            if ((nums[2] != nums[0]) && (nums[2] != nums[1]))
            {
                Console.WriteLine("43 occurs 1 time.");
            }
            else
            {
                Console.WriteLine("43 occurs many time.");
            }
        }
    }
}

namespace Tak10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of Array Elements:
            int[] nums = { 2, 5, 8 };
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("Sum of all elements stored in the array is: " + sum);
        }
    }
}

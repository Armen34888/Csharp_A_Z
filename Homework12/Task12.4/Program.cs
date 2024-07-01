using System.Globalization;

namespace Task12._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate Average with out:

            int[] nums = { 14, 67, 128, 9, 42 };
            int average;
            
            CalculateAveragewithOut(nums, out average);
            Console.WriteLine($"Average of the array: {average}");

        }

        static int CalculateAveragewithOut(int[] nums, out  int average)
        {
            int sum = 0;    
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            average = sum/nums.Length;
            return average;
        }
    }
}

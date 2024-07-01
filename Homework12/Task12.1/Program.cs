using System.Globalization;

namespace Task12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find Minimum with out:

            double[] nums = { 5.2, 6.8, -12.24, 3.4, 15.568 };
            double min;
            FindMinimumWithOut(nums, out min);
            Console.WriteLine("Min value: " +  min);
        }

        static double FindMinimumWithOut(double[] nums, out double min)
        {
            min = nums[0];
            for (int i = 1; i < nums.Length;  i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return min;
        }
    }
}

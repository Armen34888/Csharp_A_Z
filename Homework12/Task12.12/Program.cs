namespace Task12._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculate Statistics:

            int[] nums = { 2, 16, 24, 232, 7, 6, 14, 65, 982, 10, 146, };
            int sum;
            int max;
            int average;
            CalculateStatistics(nums, out sum, out average, out max);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Maximum Value: {max}");

        }
        static void CalculateStatistics(int[] nums, out int sum, out int average, out int max) 
        {
            sum = 0;
            max = nums[0];
            foreach (int num in nums)
            {
                sum += num;
                if ( num > max)
                {
                    max = num;
                }
            }
            average = sum/nums.Length;
            
        }
    }
}

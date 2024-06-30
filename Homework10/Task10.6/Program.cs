namespace Task10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print Unique Elements:
            int[] nums = { 1, 5, 1 };
            Console.Write("The unique elements found in the array are: ");

            if (nums[0] != nums[1] && nums[0] != nums[2])
            {
                Console.Write(nums[0]);
            }
            if (nums[1] != nums[0] && nums[1] != nums[2])
            {
                Console.Write(nums[1]);
            }
            if (nums[2] != nums[0] && nums[2] != nums[1])
            {
                Console.Write(nums[2]);
            }
        }
    }
}

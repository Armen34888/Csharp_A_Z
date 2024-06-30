namespace Task10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Count Duplicate Elements:
            int[] nums = { 5, 1, 1 };
            Console.Write("Total number of duplicate elements found in the array is: ");
            int dublikat = 0;
            if (nums[0] == nums[1])
            {
                dublikat++;
            }
            if (nums[0] == nums[2])
            {
                dublikat++;
            }
            if (nums[1] == nums[2])
            {
                dublikat++;
            }
            Console.WriteLine(dublikat);
        }
    }
}

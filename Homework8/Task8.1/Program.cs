namespace Task8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find the Largest Number.
            Console.WriteLine("Mutqagreq 10 tiv - ");
            int[] nums = new int[10];
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i] > max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine($"Amenamec tiv@ {max} e");
        }
    }
}

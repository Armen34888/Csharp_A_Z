namespace Task12._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find Maximum with out:
            int[] nums = { 46, 28, 129, 34, 862, 1211, 524 };
            
            int count;

            int max = FindMaximumwithout(nums, out count);
            Console.WriteLine($"Max value in the array: {max}");
            Console.WriteLine($"Count of elements in the array: {count}");
            
        }
        static int FindMaximumwithout(int[] array, out int count)
        {
            int max = array[0];
            count = array.Length;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
           
        }
    }
}

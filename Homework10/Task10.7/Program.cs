namespace Task10._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Merge Sorted Arrays:

            int[] nums = { 1, 2, 3, };
            int[] nums1 = { 1, 2, 3, };


            Console.Write("The merged array in ascending order: ");
            int[] array = new int[nums.Length + nums1.Length];
            Array.Copy(nums, array, nums.Length);
            Array.Copy(nums1, 0, array, nums.Length, nums1.Length);
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.Write(i);
                Console.Write(" ");

            }
        }
    }
}

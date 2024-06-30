namespace Task10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reverse Order:
            Console.Write("The values stored in the array are: ");
            int[] nums = new int[3];
            nums[0] = 2;
            nums[1] = 5;
            nums[2] = 7;
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write("The values stored in the array are: ");
            
            int[] nums1 = new int[3];
            nums1[0] = nums[2];
            nums1[1] = nums[1];
            nums1[2] = nums[0];
          
            
            for(int i = 0; i < nums1.Length; i++)
            {
                Console.Write(nums1[i]);
                Console.Write(" ");


            }
        }
    } 
}

using System.Globalization;

namespace Task12._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Square each element in the array.

            int[] nums = { 14, 2, 6, -12, 67, 5, 8, 125 };
            Console.Write("Original array:       ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write("Square each element: ");
            ModifyArrayWithRef(ref nums);
            
           
            Console.ReadLine(); 
        }
        static int ModifyArrayWithRef(ref int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i] * nums[i];
            }
            for (int i = 0; i < nums.Length; i++ )
            {
                Console.Write(nums[i]);
                Console.Write(" ");
            }
            return nums.Length;
            
        }
    }
}

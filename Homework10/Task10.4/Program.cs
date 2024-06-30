using System.Collections.Generic;
using System.Xml.Linq;

namespace Task10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Copy Elements to Another Array:
            int[] nums = { 15, 10, 12 };
            Console.Write("Elements stored in the first array: ");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
            int[]nums1 = new int[nums.Length];
            Console.Write("Elements stored in the second array: ");
            nums1[0] = nums[0];
            nums1[1] = nums[1];
            nums1[2] = nums[2];
            for (int i = 0;i < nums1.Length;i++)
            {
               Console.Write(nums1[i] = nums[i]);
               Console.Write(" ");
            }
            nums1[0] = nums[0];
            nums1[1] = nums[1];
            nums1[2] = nums[2];

            
        }
       
    }
}

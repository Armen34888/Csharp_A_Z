namespace Task10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print Array Elements:
            int[] nums = { 1 ,1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.Write("Elements in the array are: ");
            for (int i = 0; i < nums.Length; i++)
            {
               
                Console.Write(nums[i]);
                Console.Write(" ");
            }
           
        }
    }
}

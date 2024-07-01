namespace Task12._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get Sum and Product with out:

            int num1 = 24;
            int num2 = 36;
            int sum;
            int product;
            GetSumAndProduct(num1, num2, out  sum, out product);
            Console.WriteLine($"Input integers: {num1} and {num2}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
        }
        static void GetSumAndProduct(int num1, int num2, out int sum, out int product)
        {
            sum = num1 + num2;
            product = num1 * num2;
            

        }
    }
}

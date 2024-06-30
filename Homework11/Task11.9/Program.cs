namespace Task11._9
{
    internal class Program
    {
        // Binary Representation of Enum Values:
        enum ExampleEnum
        {
            Option1 = 1,
            Option2 = 2,
            Option3 = 4,
            Option4 = 8
        }

        static void Main(string[] args)
        {
            int integerValue = 37;
            ExampleEnum enumValue = (ExampleEnum)integerValue;

            Console.WriteLine($"Integer value: {integerValue}");
            Console.WriteLine($"Enum value: {enumValue}");
            Console.WriteLine($"Binary representation of enum value: {Convert.ToString((int)enumValue, 2)}");
        }
    }
}

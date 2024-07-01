namespace Task12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Swap Characters with ref:

            char ch1 = 'a';
            char ch2 = 'b';
            Console.WriteLine($"Before swapping: ch1 = {ch1}, ch2 = {ch2}" );
            SwapCharactersWithRef(ref ch1 , ref ch2);
            Console.WriteLine($"After swapping: ch1 = {ch1}, ch2 = {ch2}");
        }
        static void SwapCharactersWithRef(ref char ch1,ref char ch2)
        {
            char temp = ch1;
            ch1 = ch2;
            ch2 = temp;
        }
    }
}

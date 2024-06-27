namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Arajin tiv - ");
            double arajintiv = Convert.ToDouble(Console.ReadLine());
            Console.Write("Erkrord tiv - ");
            double erkrordtiv = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gorcoxutyun - ");
            string gorcoxutyun = Console.ReadLine();
            if (gorcoxutyun == "+")
            {
                Console.Write("Patasxan - ");
                Console.Write(arajintiv + erkrordtiv);
            }
            if (gorcoxutyun == "-")
            {
                Console.Write("Patasxan - ");
                Console.Write(arajintiv - erkrordtiv);
            }
            if (gorcoxutyun == "*")
            {
                Console.Write("Patasxan - ");
                Console.Write(arajintiv * erkrordtiv);
            }
            if (gorcoxutyun == "/")
            {
                Console.Write("Patasxan - ");
                Console.Write(arajintiv / erkrordtiv);
            }
        }
    }
}

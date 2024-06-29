namespace Task8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Print Even Numbers.
            Console.Write("Enter first number - ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter last number - ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine("Zuyg tver@ tvyal diapazonum hetevyaln en");
            for (int i = start; i < end; i++)
            {
                if( i % 2 == 0 )
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}

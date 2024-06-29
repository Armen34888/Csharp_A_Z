namespace Task8._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number Guessing Game.

            Random random = new Random();
            int randomnumber = random.Next(0,100);
            int pahactiv = 0;
            int porc = 0;
            while (pahactiv != randomnumber)
            {
                Console.Write("Enter number - ");
                pahactiv = int.Parse(Console.ReadLine());
                porc++;

                if (pahactiv < randomnumber)
                {
                    Console.WriteLine("Tiv@ poqr e, krkin porceq");
                }
                if (pahactiv > randomnumber)
                {
                    Console.WriteLine("Tiv@ mec e, krkin porceq");
                }
                if (pahactiv == randomnumber)
                {
                    Console.WriteLine("Duq chisht eq gushakel!");
                }

            }


        }
    }
}

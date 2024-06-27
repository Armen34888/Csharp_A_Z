namespace Task6._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Determine the Type of Triangle.
            int a = 10; 
            int b = 10; 
            int c = 14;
            if(a != b )
            {
                if(b != c)
                {
                    if (a != c)
                    {
                        Console.WriteLine("Erankyunn uni tarber koxmer");
                    }
                }
            }
            if ( a == b )
            { 
                if ( b != c)
                {
                    if ( a != c)
                    {
                        Console.WriteLine("Erankyun@ havasarasrun e");
                    }
                }
            }
            if( a == b )
            {
                if (b == c)
                {
                    if ( a == c)
                    {
                        Console.WriteLine("Erankyun@ havasarakoxm e");
                    }
                }
            }
             

            
        }
    }
}

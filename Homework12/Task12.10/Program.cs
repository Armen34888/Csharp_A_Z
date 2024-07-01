namespace Task12._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prime Numbers:
            int N = 20;
            int[] primes = GenerateNPrimes(N);
            Console.WriteLine($"The first {N} prime numbers are:");
            foreach (int i in primes)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] GenerateNPrimes(int N)
        {
            int[] primes = new int[N];
            int count = 0;
            int startnumber = 2;
            while (count < N)
            {
                if (IsPrime(startnumber))
                {
                    primes[count] = startnumber;
                    count++;
                }
                startnumber++;
            }
            return primes;

        }
        public static bool IsPrime(int num)
        {
        if ( num < 2 )
            {
                return false;
            }
        if ( num == 2 )
            {
                return true;    
            }
        if (num % 2 == 0 )
            {
                return false;
            }
        int sqrt = (int)Math.Sqrt(num);
            for (int i = 3; i < sqrt; i++)
            {
                if ( num % i == 0 ) 
                { 
                    return false;
                }
            }
            return true;
        }
    }
}

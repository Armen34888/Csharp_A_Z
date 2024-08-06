using System.Collections;
using System.Collections.Generic;
using System;

namespace Task18._3
   
{
    internal class Program
    {
        // Generate the Fibonacci sequence using yield return.
        static void Main(string[] args)
        {
            ;
            foreach (var fib in FibonacciSequence(100))
            {
                Console.Write(fib + " ");
            }
        }
        public static IEnumerable FibonacciSequence(int limit)
        {
            int a = 0;
            int b = 1;

            while (a <= limit)
            {
                yield return a;
                int next = a + b;
                a = b;
                b = next;
            }
        }


    }
    


}

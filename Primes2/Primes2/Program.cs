using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Primes2
{
    class Program
    {
        //Finding the prime numbers
        void primeNum(int biggestCheckedNum)
        {
            for (int i = 2; i <= biggestCheckedNum; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++) 
                {
                    if (i % j == 0) 
                    {
                        isPrime = false;
                        break;
                    }
                }
                // Displaying the number if it's a prime
                if (isPrime)
                {
                    Console.WriteLine("Prime:" + i);
                }    
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.primeNum(999);
            Console.ReadLine();
        }
    }
}

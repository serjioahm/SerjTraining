using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumbersArr
{
    class Program
    {
        //Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes algorithm.
        //The program should print the biggest prime number which is <= N.
        //On the first line you will receive the number N
        //Print the biggest prime number which is <= N
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int length = int.Parse(Console.ReadLine());

            var isPrime = new byte[length + 1];
            int result = 0;

            for (int i = 2; i <= length; i++)
            {
                if (isPrime[i] == 0)
                {
                    result = i;

                    for (int j = i * 2; j <= length; j += i)
                    {
                        isPrime[j] = 1;
                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}

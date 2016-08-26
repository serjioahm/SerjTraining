using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System

namespace Nfactorial
{
    class Program
    {
        //Write a method that multiplies a number represented as an array of digits by a given integer number.
        //Write a program to calculate N!.
        //On the first line you will receive the number N
        //Print N!
        static void Main(string[] args)
        {
            Console.Write("The number is = ");
            var number = int.Parse(Console.ReadLine());
            var array = ConvertToArray(number);
            long factorial = CalculateFactorial(array);
            Console.WriteLine("Factorial of the inserted number is : "+ factorial);
        }
        private static long CalculateFactorial(long[] number)
        {
            long factorial = 1;
            for (int i = 0; i < number.Length; i++)
            {
                factorial *= number[i];
            }

            return factorial;
        }
        private static long[] ConvertToArray(int number)
        {
            long[] numberAsArray = new long[number];

            for (int i = 0; i < number; i++)
            {
                numberAsArray[i] = i + 1;
            }

            return numberAsArray;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCharArrays
{
    class Program
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).
        //On the first line you will receive the first char array as a string
        //On the second line you will receive the second char array as a string
        //Print < if the first array is lexicographically smaller
        //Print > if the second array is lexicographically smaller
        //Print = if the arrays are equal
        static void Main(string[] args)
        {
            Console.WriteLine("Enter elements of the first array...");
            string arrA = Console.ReadLine();
            Console.WriteLine("Enter elements of the second array...");
            string arrB = Console.ReadLine();

            bool areEqual = true;
            string result = string.Empty;

            var length = Math.Min(arrA.Length, arrB.Length);

            {
                for (int i = 0; i < length; i++)
                {
                    if (arrA[i] != arrB[i])
                    {
                        areEqual = false;
                        result = (arrA[i] < arrB[i]) ? "<" : ">";
                        break;
                    }
                    else
                    {
                        if (arrA.Length != arrB.Length)
                        {
                            areEqual = false;
                            result = (arrA.Length < arrB.Length) ? "<" : ">";
                        }
                    }
                }
            }

            Console.WriteLine(areEqual ? "=" : result);
        }
    }
}

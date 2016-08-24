using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaximalKSum
{
    class Program
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console.
        //Find the maximal sum of K elements in the array.
        //On the first line you will receive the number N
        //On the second line you will receive the number K
        //On the next N lines the numbers of the array will be given
        //Print the maximal sum of K elements in the array
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter elements of the array...");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = 0;

            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 0; i < k; i++)
            {
                maxSum += array[i];
            }

            Console.WriteLine("The maximal sum is: " + maxSum);

        }
    }
}

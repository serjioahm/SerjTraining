using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaximalSum
{
    class Program
    {
        //Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
        //On the first line you will receive the number N
        //On the next N lines the numbers of the array will be given
        //Print the maximal sum of consecutive numbers
        static void Main(string[] args)
        {
            Console.Write("Enter length of the array: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];

            Console.WriteLine("Enter elements of the array...");
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxSum = int.MinValue;
            int currentSum = 0;
            int tmpStart = 0;
            int end = length;
            int start = 0;

            for (int j = 0; j != length; ++j)
            {
                currentSum += arr[j];
                end = j;

                // if the sum is equal, choose the one with more elements
                if (currentSum > maxSum || (currentSum == maxSum && (end - start) < (j - tmpStart)))
                {
                    maxSum = currentSum;
                    start = tmpStart;
                    end = j;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                    tmpStart = j + 1;
                }
            }

            Console.WriteLine("The maximal sum is" + maxSum);
        }
    }
}

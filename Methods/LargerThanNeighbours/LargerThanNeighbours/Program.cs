using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LargerThanNeighbours
{
    class Program
    {
        //Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
        //Write program that reads an array of numbers and prints how many of them are larger than their neighbours.
        //On the first line you will receive the number N - the size of the array
        //On the second line you will receive N numbers separated by spaces - the array
        //Print how many numbers in the array are larger than their neighbours
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            var length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements ...");
            int[] array = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var counter = CountBiggerThanNeighbours(array);

            Console.WriteLine("The numbers that are larger than their neighbours are :"+counter);
        }

        private static int CountBiggerThanNeighbours(int[] numbers)
        {
            var counter = 0;

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}

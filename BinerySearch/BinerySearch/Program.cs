using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinerySearch
{
    class Program
    {
        //Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
        //On the first line you will receive the number N
        //On the next N lines the numbers of the array will be given
        //On the last line you will receive the number X
        //Print the index where X is in the array
        //If there is more than one occurence print the first one
        //If there are no occurences print -1

        static void Main()
        {

            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] unsortedArr = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter number {0}: ",i);
                unsortedArr[i] = int.Parse(Console.ReadLine());
            }
            //int[] unsortedArr = { 9, 6, 90, 44, 23, 50, 7, 66, 13, 10 };
            //int key = 8;
            Console.Write("Enter the number we are looking for: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("That's the index of the number :"+ BinSearch(unsortedArr, key));
        }
        static int BinSearch(int[] array, int key)
        {
            Array.Sort(array);
            int indexMax = array.Length - 1;
            int indexMin = 0;
            while (indexMax >= indexMin)
            {
                int indexMiddle = (indexMin + indexMax) / 2;
                if (array[indexMiddle] < key)
                {
                    indexMin = indexMiddle + 1;
                }
                else if (array[indexMiddle] > key)
                {
                    indexMax = indexMiddle - 1;
                }
                else
                {
                    return indexMiddle;
                }
            }
            return -1;
        }
       
    }
}

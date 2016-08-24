using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSortArr
{
    class Program
    {
        //Write a program that sorts an array of integers using the Quick sort algorithm.
        //On the first line you will receive the number N
        //On the next N lines the numbers of the array will be given
        //Print the sorted array
        //Each number should be on a new line
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Index {0} -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            QuicSortAlgorithm(array, 0, length - 1);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void QuicSortAlgorithm(int[] arr, int left, int right)
        {
            int midIndex = (left + right) / 2;
            int leftIndex = left;
            int rightindex = right;
            int middle = arr[midIndex];

            while (leftIndex <= rightindex)
            {
                while (arr[leftIndex] < middle)
                {
                    leftIndex++;
                }

                while (arr[rightindex] > middle)
                {
                    rightindex--;
                }

                if (leftIndex <= rightindex)
                {
                    int temp = arr[leftIndex];
                    arr[leftIndex] = arr[rightindex];
                    arr[rightindex] = temp;
                    leftIndex++;
                    rightindex--;
                }

                if (left < rightindex)
                {
                    QuicSortAlgorithm(arr, left, rightindex);
                }

                if (leftIndex < right)
                {
                    QuicSortAlgorithm(arr, leftIndex, right);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSortArray
{
    class Program
    {
        //Write a program that sorts an array of integers using the Merge sort algorithm
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

            array = SplitArray(array);

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }

        public static int[] SplitArray(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int middle = arr.Length / 2;
            int[] leftArr = new int[middle];
            int[] rigthArr = new int[arr.Length - middle];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    leftArr[i] = arr[i];
                }
                else
                {
                    rigthArr[i - middle] = arr[i];
                }
            }

            leftArr = SplitArray(leftArr);
            rigthArr = SplitArray(rigthArr);

            return MergeArrays(leftArr, rigthArr);
        }

        public static int[] MergeArrays(int[] left, int[] right)
        {
            int leftIndex = 0;
            int rightIndex = 0;
            int[] arr = new int[left.Length + right.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (rightIndex == right.Length
                    || (leftIndex < left.Length
                    && left[leftIndex] <= right[rightIndex]))
                {
                    arr[i] = left[leftIndex];
                    leftIndex++;
                }
                else if (leftIndex == left.Length
                    || (rightIndex < right.Length
                    && left[leftIndex] >= right[rightIndex]))
                {
                    arr[i] = right[rightIndex];
                    rightIndex++;
                }
            }

            return arr;
        }
    }
}

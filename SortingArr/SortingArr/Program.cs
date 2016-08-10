using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingArr
{
    class Program
    {
        //Write a method that returns the maximal element in a portion of array of integers starting at given index.
        //Using it write another method that sorts an array in ascending / descending order.
        //Write a program that sorts a given array.
        //On the first line you will receive the number N - the size of the array
        //On the second line you will receive N numbers separated by spaces - the array
        //Print the sorted array
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrLength];

            Console.WriteLine("Enter array elements :");
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Index [{0}] -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
           /* Console.Write("Numbers = ");
            string[] strArr = Console.ReadLine().Split();
            for (int i = 0; i < arrLength; i++)
                array[i] = int.Parse(strArr[i]);*/




            Console.Write("Enter first index of the portion that you want to search: ");
            int firstIndex = int.Parse(Console.ReadLine());

            MaxElementInArr(array);
            int maxElemInPort=MaxElementInPortOfArr(array, firstIndex);
            SortArray(array, maxElemInPort, firstIndex);
        }

        static void MaxElementInArr(int[] array)
        {
            int maxElement = array.Max();
            Console.WriteLine("The biggest element in  the array is: " + maxElement);
        }

        static int MaxElementInPortOfArr(int[] array, int firstIndex)
        {
            int maxElementInPort = 0;
            for (int i = firstIndex; i < array.Length; i++)
            {
                if (array[i] > maxElementInPort)
                {
                    maxElementInPort = array[i];
                }
            }
            Console.WriteLine("Max element in the portion of array is: " + maxElementInPort);
            return maxElementInPort;
        }

        static void SortArray(int[] array, int maxElemInPortion, int firstIndex)
        {
            
            int number = 0;
            
            //Sorting an array in ascending order
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        number = array[j];
                        array[j] = array[i];
                        array[i] = number;
                    }
                }
            }
           /* for (int i = 0; i < firstIndex; i++)
            {
                if (array[i] > maxElemInPortion)
                {
                    number = maxElemInPortion;
                    maxElemInPortion = array[i];
                    array[i]
                }
            }*/


            //Print array in ascending order
            Console.WriteLine("Sort array...");
            Console.Write("In  ascending order: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();

            //Sorting array in descending order
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        number = array[j];
                        array[j] = array[i];
                        array[i] = number;
                    }
                }
            }

            //Print array int descendin 
            Console.Write("In descending order: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }

    }
}

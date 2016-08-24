using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectionSort
{
    class Program
    {
        //Write a program to sort an array. Use the Selection sort algorithm:
        //Find the smallest element, move it at the first position, find the smallest from the rest,
        //move it at the second position, etc.
        //On the first line you will receive the number N
        //On the next N lines the numbers of the array will be given
        //Print the sorted array
        //Each number should be on a new line
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            int number = 0;

            Console.WriteLine("Enter elements of the array...");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Index {0} -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }
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

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            } 
        }
    }
}

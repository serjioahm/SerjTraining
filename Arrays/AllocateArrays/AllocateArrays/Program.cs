using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllocateArrays
{
    class Program
    {
        //Write a program that allocates array of N integers, initializes each element by its index
        //multiplied by 5 and the prints the obtained array on the console.
        //On the only line you will receive the number N
        //Print the obtained array on the console.
        //Each number should be on a new line
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = 5 * i;
                Console.WriteLine(array[i]);
            }
        }
    }
}

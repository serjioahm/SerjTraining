using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxIncreasingSeq
{
    class Program
    {
        //Write a program that finds the length of the maximal increasing sequence in an array of N integers
        //On the first line you will receive the number N
        //On the next N lines the numbers of the array will be given
        //Print the length of the maximal increasing sequence
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrayLength];
            arr[0] = int.Parse(Console.ReadLine());
            int maxSequence = 0;
            int currentSequence = 1;

            for (int i = 1; i < arrayLength; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] >= arr[i - 1] + 1)
                {
                    var temp1 = arr[i - 1];
                    var temp2 = arr[i];
                    currentSequence += 1;
                    maxSequence = Math.Max(maxSequence, currentSequence);
                }
                else
                {
                    currentSequence = 1;
                }
            }

            Console.WriteLine("The maximal increasing sequence is : " + maxSequence);
        }
    }
}

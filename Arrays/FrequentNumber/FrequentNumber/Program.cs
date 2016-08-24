using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrequentNumber
{
    class Program
    {
        //Write a program that finds the most frequent number in an array of N elements.
        //On the first line you will receive the number N
        //On the next N lines the numbers of the array will be given
        //Print the most frequent number and how many time it is repeated
        //Output should be REPEATING_NUMBER (REPEATED_TIMES times)
        static void Main(string[] args)
        {
            Console.Write("Enter length of the array: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            Console.WriteLine("Enter elements of the array:");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Index {0} -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            int maxCounter = 1;
            int tempCounter = 1;
            int mostFrequentNumber = 0;

            if (arrayLength == 1)
            {
                mostFrequentNumber = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    tempCounter++;
                }
                else
                {
                    if (tempCounter > maxCounter)
                    {
                        maxCounter = tempCounter;
                        mostFrequentNumber = array[i];
                        tempCounter = 1;
                    }
                    else
                    {
                        tempCounter = 1;
                    }
                }
            }

            if (tempCounter > maxCounter)
            {
                maxCounter = tempCounter;
                mostFrequentNumber = array[array.Length - 1];
            }

            /// 4(5 times)
            /// string outputFormat = "{0} ({1} times)";
            Console.WriteLine("{0} ({1} times)", mostFrequentNumber, maxCounter);
        }
    }
}

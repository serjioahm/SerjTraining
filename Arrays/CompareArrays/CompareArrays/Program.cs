using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareArrays
{
    class Program
    {
        //Write a program that reads two integer arrays of size N from the console and compares them element by element.
        //On the first line you will receive the number N
        //On the next N lines the numbers of the first array will be given
        //On the next N lines the numbers of the second array will be given
        //Print Equal if the two arrays are the same and Not equal if they are not
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the two arrays: ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] firstArray = new int[arrLength];
            int[] secondArray = new int[arrLength];

            Console.WriteLine("Enter the elements of the first array...");
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Enter number: ");
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter element's of the second array... ");
            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Enter number: ");
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            //Compare elements of the two arrays
            for (int i = 0; i < arrLength; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
                }
                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("{0} < {1}", firstArray[i], secondArray[i]);
                }
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("{0} > {1}", firstArray[i], secondArray[i]);
                }
            }
            //Check if two arrays are EQUAL
            bool check = true;

            for (int i = 0; i < arrLength; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    check = false;
                    break;
                }
            }
            if (check == true)
            {
                Console.WriteLine("The arrays are Equal!");
            }
            else
            {
                Console.WriteLine("The arrays are NOT Equal!");
            }
        }
    }
}

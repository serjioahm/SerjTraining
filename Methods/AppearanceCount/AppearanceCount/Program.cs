using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppearanceCount
{
    class Program
    {
        //Write a method that counts how many times given number appears in a given array.
        //Write a test program to check if the method is working correctly.
        //On the first line you will receive a number N - the size of the array
        //On the second line you will receive N numbers separated by spaces - the numbers in the array
        //On the third line you will receive a number X
        //Print how many times the number X appears in the array
        static void Main(string[] args)
        {
            Program task = new Program();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("sizeOfArray = ");
            var sizeOfArray = int.Parse(Console.ReadLine());

            Console.Write("Numbers = ");
            //string[] strArr = new string[] {Console.ReadLine()};
            string[] strArr = Console.ReadLine().Split();


            int[] numbers = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
                numbers[i] = int.Parse(strArr[i]);
            Console.Write("Counted number is = ");
            int countedNumber = int.Parse(Console.ReadLine());

            int matchesFound = task.AppearCount(countedNumber, numbers);
            Console.WriteLine("The matches are:" + matchesFound);
        }

        public int AppearCount(int countedNumber, int[] intArr)
        {
            int numberMatches = 0;
            int lengthOfArr = intArr.Length;

            for (int i = 0; i < lengthOfArr; i++)
            {
                if (intArr[i] == countedNumber)
                    numberMatches++;
            }
            return numberMatches;
        }
    }
}

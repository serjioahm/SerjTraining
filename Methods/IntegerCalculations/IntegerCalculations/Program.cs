using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerCalculations
{
    class Program
    {
        //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
        //Use variable number of arguments. Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.
        //On the first line you will receive 5 numbers separated by spaces
        //Print their minimum, maximum, average, sum and product
        //Each on a new line
        //The average value should be printed with two digits of precision
        //Each of the five numbers will be in the interval [ -1000, 1000 ]
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers: ");
            var arr = ConvertToArray(Console.ReadLine());

            Console.WriteLine("The minimum number is " + GetMinNumber(arr));
            Console.WriteLine("The max number is " + GetMaxNumber(arr));
            Console.WriteLine("The avg of the numbers is " + GetAvarage(arr));
            Console.WriteLine("The calculated sum is " + CalculateSum(arr));
            Console.WriteLine("The product of the numbers is " + CalculateProduct(arr));
        }
        private static int[] ConvertToArray(string number)
        {
            int[] num = number
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            return num;
        }
        private static double GetAvarage(int[] arr)
        {
            double avarage = 0;
            avarage = CalculateSum(arr) / (double)arr.Length;

            return avarage;
        }
        private static long CalculateSum(int[] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
        private static long CalculateProduct(int[] arr)
        {
            long product = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }

            return product;
        }
        private static int GetMaxNumber(int[] arr)
        {
            int max = int.MinValue;

            Array.Sort(arr);
            max = arr[arr.Length - 1];
            return max;
        }
        private static int GetMinNumber(int[] arr)
        {
            int min = int.MaxValue;

            Array.Sort(arr);
            min = arr[0];
            return min;
        }
    }
}

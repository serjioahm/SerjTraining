using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstLargerThanNeigh
{
    class Program
    {
        //Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there is no such element.
        //On the first line you will receive the number N - the size of the array
        //On the second line you will receive N numbers sepated by spaces - the array
        //Print the index of the first element that is larger than its neighbours or -1 if none are
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            var length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements ...");
            int[] array = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var counter = FirstBiggerThanNeighbours(array);

            Console.WriteLine("The first number that is larger than its neighbours is :" + counter);
        }

        private static int FirstBiggerThanNeighbours(int[] numbers)
        {
            var index = -1;

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    index=i;
                    break;
                }
            }

            return index;
        }
    }
}

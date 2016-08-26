using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseNumber
{
    class Program
    {
        //Write a method that reverses the digits of a given decimal number.
        //On the first line you will receive a number
        //Print the given number with reversed digits
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            var number = Console.ReadLine();
            Console.WriteLine(GetReverseNumber(number));
        }
        private static string GetReverseNumber(string number)
        {
            char[] reversedNumber = number.ToCharArray();
            Array.Reverse(reversedNumber);
            return new string(reversedNumber);
            //return reversedNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishDigit
{
    class Program
    {
        //Write a method that returns the last digit of given integer as an English word.
        //Write a program that reads a number and prints the result of the method.
        //On the first line you will receive a number
        //Print the last digit of the number as an English word

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(LastEnglishDigit(number));
        }

        private static string LastEnglishDigit(int number)
        {
            var word = string.Empty;
            number = number % 10;
            switch (number)
            {
                case 0:
                    word = "zero";
                    break;
                case 1:
                    word = "one";
                    break;
                case 2:
                    word = "two";
                    break;
                case 3:
                    word = "three";
                    break;
                case 4:
                    word = "four";
                    break;
                case 5:
                    word = "five";
                    break;
                case 6:
                    word = "six";
                    break;
                case 7:
                    word = "seven";
                    break;
                case 8:
                    word = "eight";
                    break;
                case 9:
                    word = "nine";
                    break;
            }

            return word;
        }


    }
}

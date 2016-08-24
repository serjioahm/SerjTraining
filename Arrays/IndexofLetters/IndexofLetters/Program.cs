using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexofLetters
{
    class Program
    {
        //Write a program that creates an array containing all letters from the alphabet (a-z).
        //Read a word from the console and print the index of each of its letters in the array.
        //On the first line you will receive the word
        //Print the index of each of the word's letters in the array
        //Each index should be on a new line
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine().ToLower();

            char[] englishAlphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'g', 'k', 'l', 'm', 'n', 
                                     'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            foreach (char letter in word)
            {
                for (int i = 0; i < englishAlphabet.Length; i++)
                {
                    if (letter == englishAlphabet[i])
                    {
                        Console.WriteLine("Letter \"{0}\" index in array -> {1}", letter, i);
                    }
                }
            }
        }
    }
}

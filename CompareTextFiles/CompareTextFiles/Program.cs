using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CompareTextFiles
{
    class Program
    {
        static void Main()
        {
            string[] fileOne = File.ReadAllLines("../../file.txt");
            string[] fileTwo = File.ReadAllLines("../../file2.txt");

            int equalLines = 0;
            for (int i = 0; i < fileOne.Length; i++)
            {
                if (fileOne[i] == fileTwo[i])
                {
                    equalLines++;
                }
            }

            Console.WriteLine("file.txt: ");
            PrintFileContent(fileOne);
            Console.WriteLine();
            Console.WriteLine("file2.txt: ");
            PrintFileContent(fileTwo);
            Console.WriteLine();

            Console.WriteLine("Equal Lines: {0}", equalLines);
            Console.WriteLine("Different Lines {0}", fileOne.Length - equalLines);
        }

        static void PrintFileContent(string[] file)
        {
            for (int i = 0; i < file.Length; i++)
            {
                Console.WriteLine(file[i]);
            }
        }
    }
}

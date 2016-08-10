using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TwoFilesToThird
{
    class Program
    {
        //Write a program that concatenates two text files into another text file.
        static void Main()
        {
            string fileOne = File.ReadAllText("../../file.txt");
            string fileTwo = File.ReadAllText("../../file2.txt");
            //Environment.NewLine
            using (StreamWriter writer = File.CreateText("../../file3.txt"))
            {
                writer.Write(fileOne + "\n" + fileTwo);
                Console.WriteLine("The new file is created.");
            }
        }
    }
}

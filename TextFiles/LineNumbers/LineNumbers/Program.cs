using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        //Write a program that reads a text file and inserts line numbers in front of each of its lines.
        //The result should be written to another text file.
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../file.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../file10.txt"))
                {
                    string line;
                    int lineCounter = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine("{0}. {1}", lineCounter, line);
                        lineCounter++;
                    }
                    Console.WriteLine("The lines of the first file are added!");
                }
            }
        }
    }
}

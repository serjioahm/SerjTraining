﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadingOddLines
{
    class Program
    {
        //Read the odd lines of a file and print them.
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../file.txt"))
            {
                string line;
                int lineCounter = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineCounter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineCounter++;
                }
            }
        }
    }
}

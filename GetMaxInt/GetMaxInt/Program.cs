using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetMaxInt
{
    class Program
    {

        public int GetMax(int x,int y) 
        {
            return Math.Max(x, y);
        }

        static void Main(string[] args)
        {

            Program task = new Program();
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Write 3 integers separated with spaces:");

            string[] stringArr = Console.ReadLine().Split();
            var len = stringArr.Length;
            int[] intArr = new int[len];
            for (int i = 0; i < len; i++)
                intArr[i] = Convert.ToInt32(stringArr[i]);

            int firstPair = task.GetMax(intArr[0], intArr[1]);
            int secondPair = task.GetMax(firstPair, intArr[2]);
            Console.WriteLine(secondPair);
        }
    }
}

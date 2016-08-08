using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GetMaxInt
{
    class Program
    {

        public void GetMax(int x,int y) 
        {

            Console.WriteLine("\n The largest number is " + Math.Max(x,y));

            Console.Write("Press Enter to exit");
            Console.ReadLine(); 
        }

        static void Main(string[] args)
        {

            Program task = new Program();
            Console.ForegroundColor = ConsoleColor.Cyan;

            //int x=22,y=222,z=222;
            Console.Write("Write 3 integers separated with spaces:");

            string[] stringArr = Console.ReadLine().Split();
            var len = stringArr.Length;
            int[] intArr = new int[len];
            for (int i = 0; i < len; i++)
                intArr[i] = Convert.ToInt32(stringArr[i]);

            task.GetMax(intArr[0], Math.Max(intArr[1], intArr[2]));

        }
    }
}

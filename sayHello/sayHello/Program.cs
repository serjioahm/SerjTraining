using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sayHello
{
    class Program
    {
        public void Answer()
        {
            //Collecting user input

            Console.Write("Indentify your name:");

            string name = Console.ReadLine();

            Console.WriteLine("\n Hello "+ name);

            Console.Write("Press Enter to exit");
            Console.ReadLine();    
        }
        static void Main(string[] args)
        {
            Program task = new Program();
            Console.ForegroundColor = ConsoleColor.Cyan;
            task.Answer();
        }
    }
}

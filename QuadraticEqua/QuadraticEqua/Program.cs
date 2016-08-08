using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;



namespace QuadraticEquations

{

    class QuadraticEquations

    {

        public static double a;

        public static double b;

        public static double c;


        public void QuadRoots ()

        {

            string menu;

            double Formula;

            double x1;

            double x2;         

            //Collecting user input

            Console.WriteLine("Enter a");

            a = Convert.ToDouble(Console.ReadLine());

            //Collecting user input

            Console.WriteLine("Enter b");

            b = Convert.ToDouble(Console.ReadLine());

            //Collecting user input

            Console.WriteLine("Enter c");

            c = Convert.ToDouble(Console.ReadLine());

            //Calculating the roots of the equation using quadratic formula

            Formula = Convert.ToDouble(Math.Sqrt(b * b - 4 * a * c));

            x1 = -b - Formula;

            x2 = -b + Formula;

            x1 /= (2 * a);

            x2 /= (2 * a);

            //displaying roots of the quadratic equation           

            Console.WriteLine("\t X1 = " + x1);

            Console.WriteLine("\t X2 = " + x2 + "\n");

            Console.WriteLine("\n 1.Exit");

            Console.WriteLine(" 2.New quadratic equation solver");

            menu = Console.ReadLine();

            Console.WriteLine("************************************************************************************");

          

            switch (menu)

            {

                case "1": Console.Clear();

                    break;

                case "2": Console.Clear();

                    QuadRoots();

                    break;

                default: Console.WriteLine("Invalid choice");

                    QuadRoots();

                    break;

            }

        }

        static void Main()

        {

            Console.Title="Quadratic Equation Formula";           

            QuadraticEquations task = new QuadraticEquations();

            Console.ForegroundColor = ConsoleColor.Cyan;

            task.QuadRoots();

        }

    }

}
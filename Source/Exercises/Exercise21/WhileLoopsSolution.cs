using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise21
{
    class Runner
    {
        public void Run()
        {
            WhileLoopsSolution s = new WhileLoopsSolution();
            s.MyCode();
        }
    }

    class WhileLoopsSolution
    {
        public void MyCode()
        {
            // case 1
            Console.WriteLine("Start of case 1");
            int c1 = 1;
            while (c1 < 20)
            {
                Console.WriteLine(c1);
                c1 = c1 + 2;
            }

            // case 2
            Console.WriteLine("Start of case 2");
            int c2 = 1;
            while (c2 < 20)
            {
                Console.WriteLine(c2);
                c2 = c2 * 2;
            }

            // case 3
            Console.WriteLine("Start of case 3");
            int c3 = 15;
            while ((c3 < 20) && (c3 > 10))
            {
                Console.WriteLine(c3);
                c3++;
            }

            // case 4
            Console.WriteLine("Start of case 4");
            int c4 = 10;
            while (c4 >= 0)
            {
                Console.WriteLine(c4);
                c4--;
            }

            // insert code for the below four cases

            // case 5
            // print out the numbers 3,5,7,9
            Console.WriteLine("Start of case 5");
            int c5 = 3;
            while (c5 < 10)
            {
                Console.WriteLine(c5);
                c5 += 2;
            }

            // case 6
            // print out the numbers 0,1,3,7,15,31
            Console.WriteLine("Start of case 6");
            int c6 = 0;
            while (c6 < 63)
            {
                Console.WriteLine(c6);
                c6 = 2 * c6 + 1;
            }

            // case 7
            // print out the numbers 100,50,25,12,6,3,1
            Console.WriteLine("Start of case 7");
            int c7 = 100;
            while (c7 > 0)
            {
                Console.WriteLine(c7);
                c7 = c7 / 2;
            }

            // case 8 (difficult)
            // print out the numbers 10,9,12,7,14,5,16,3,18,1
            Console.WriteLine("Start of case 8");
            int c8 = 0;
            while (c8 < 10)
            {
                if ((c8 % 2) == 0)
                {
                    Console.WriteLine(10 + c8);
                }
                else
                {
                    Console.WriteLine(10 - c8);
                }
                c8++;
            }
        }
    }
}

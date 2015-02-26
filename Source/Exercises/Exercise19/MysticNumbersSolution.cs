using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise19
{
    class Runner
    {
        public void Run()
        {
            // 1
            MysticNumbersSolution m = new MysticNumbersSolution();
            Console.WriteLine(m.ThreeNumbers(1, 2, 3));
            Console.WriteLine(m.ThreeNumbers(2, 3, 1));
            Console.WriteLine(m.ThreeNumbers(3, 2, 1));

            // 2
            Console.WriteLine(m.TwoNumbers(1, 2));
            Console.WriteLine(m.TwoNumbers(2, 1));

            // 3
            Console.WriteLine(m.FourNumbers(1, 2, 3, 4));
            Console.WriteLine(m.FourNumbers(1, 4, 3, 2));
            Console.WriteLine(m.FourNumbers(1, 2, 4, 3));
            Console.WriteLine(m.FourNumbers(4, 2, 3, 1));

            // 4
            Console.WriteLine(m.ThreeNumbersVersion2(1, 2, 3));
            Console.WriteLine(m.ThreeNumbersVersion2(2, 3, 1));
            Console.WriteLine(m.ThreeNumbersVersion2(3, 2, 1));
        }
    }

    class MysticNumbersSolution
    {
        // finds the largest of the three given numbers
        public int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            return result;
        }

        // 2 - finds the largest of the two numbers
        public int TwoNumbers(int a, int b)
        {
            //int result = a;
            //if (b > a) {
            //    result = b;
            //}
            //return result;

            // or
            return a > b ? a : b;
        }

        // 3 - finds the largest of four numbers using TwoNumbers
        public int FourNumbers(int a, int b, int c, int d)
        {
            int x = TwoNumbers(a, b);
            int y = TwoNumbers(c, d);
            int result = TwoNumbers(x, y);
            return result;
        }

        // 4 - finds the largest of three numbers using TwoNumbers
        public int ThreeNumbersVersion2(int a, int b, int c)
        {
            int x = TwoNumbers(a, b);
            int result = TwoNumbers(x, c);
            return result;
        }
    }
}

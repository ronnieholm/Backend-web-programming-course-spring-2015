using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise08
{
    class LogicalExpressionsIISolution
    {
        public void MyCode()
        {
            int a = 7;
            int b = 12;

            // 1
            bool b1 = a < 10;
            Console.WriteLine(b1);

            // 2
            bool b2 = a >= 7;
            Console.WriteLine(b2);

            // 3
            bool b3 = a != 12;
            Console.WriteLine(b3);

            // 4
            bool b4 = a < 10 && a > 5;
            Console.WriteLine(b4);

            // 5
            bool b5 = a < 10 && b != 10;
            Console.WriteLine(b5);

            // 6
            bool b6 = a > 10 || b > 10;
            Console.WriteLine(b6);

            // 7
            bool b7 = (b >= 0 && b <= 20) && a < 8;
            Console.WriteLine(b7);

            // 8
            bool b8 = (a + b) > (a - b);
            Console.WriteLine(b8);
        }
    }
}

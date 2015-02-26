using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise21
{
    // begin copy

    class WhileLoops
    {
        public void MyCode()
        {
            // case 1
            Console.WriteLine("Start of case 1");
            int c1 = 1;
            while (c1 < 20)
            {
                // Console.WriteLine(c1);
                c1 = c1 + 2;
            }

            // case 2
            Console.WriteLine("Start of case 2");
            int c2 = 1;
            while (c2 < 20)
            {
                // Console.WriteLine(c2);
                c2 = c2 * 2;
            }

            // case 3
            Console.WriteLine("Start of case 3");
            int c3 = 15;
            while ((c3 < 20) && (c3 > 10))
            {
                // Console.WriteLine(c3);
                c3++;
            }

            // case 4
            Console.WriteLine("Start of case 4");
            int c4 = 10;
            while (c4 >= 0)
            {
                // Console.WriteLine(c4);
                c4--;
            }

            // insert code for the below four cases

            // case 5
            // print out the numbers 3,5,7,9

            // case 6
            // print out the numbers 0,1,3,7,15,31

            // case 7
            // print out the numbers 100,50,25,12,6,3,1

            // case 8 (difficult)
            // print out the numbers 10,9,12,7,14,5,16,3,18,1
        }
    }

    // end copy
}

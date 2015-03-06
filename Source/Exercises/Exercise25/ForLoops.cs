using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise25
{
    class ForLoops
    {
        public void MyCode()
        {
            // case 1
            Console.WriteLine("Start of case 1");
            for (int i = 0; i < 15; i = i + 3)
            {
                // Console.WriteLine(i);
            }

            // case 2
            Console.WriteLine("Start of case 2");
            for (int i = 10; i >= 3; i--)
            {
                // Console.WriteLine(i);
            }

            // case 3. Change to for loop
            Console.WriteLine("Start of case 3");
            int c3 = 0;
            while (c3 < 12)
            {
                c3 = c3 + 2;
                Console.WriteLine(c3);
            }

            // case 4. Change this to a for-loop
            Console.WriteLine("Start of case 4");
            int c4 = 0;
            while (c4 < 50)
            {
                Console.WriteLine(c4);
                c4 = c4 * 2 + 2;
            }
        }
    }
}

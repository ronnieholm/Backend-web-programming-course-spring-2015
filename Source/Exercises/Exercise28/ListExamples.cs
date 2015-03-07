using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise28
{
    class ListExamples
    {
        public void Run()
        {
            List<int> aListOfInt = new List<int>();
            aListOfInt.Add(4);
            aListOfInt.Add(12);
            aListOfInt.Add(9);

            // case 1
            //Console.WriteLine("Case 1: Element with index 1 is {0}", aListOfInt[1]);

            // case 2
            //Console.WriteLine("Case 2: List contains {0} elements", aListOfInt.Count);

            aListOfInt.Add(5);
            aListOfInt.Add(22);

            // case 3
            //Console.WriteLine("Case 3: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.RemoveAt(0);

            // case 4
            //Console.WriteLine("Case 4: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.Clear();
            aListOfInt.Add(14);
            aListOfInt.Add(87);
            aListOfInt.Add(62);
            aListOfInt.Add(21);
            aListOfInt.Add(40);
            aListOfInt.Add(3);

            // case 5: add code that prints out all elements in the list

            // add code here

            // case 6: add code that sums elements in list and prints result

            // add code here

            // case 7: add code to find average of elements in list and prints result
            // Tip: think about how average is defined. Then you might reuse pieces of 
            // case 6

            // add code here

            // case 8: add code to find smallest element in list and print result.
            // Tip: think about how you would do this manually

            // add code here
        }
    }
}

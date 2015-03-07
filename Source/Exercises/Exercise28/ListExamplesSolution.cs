using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise28
{
    class ListExamplesSolution
    {
        public void Run()
        {
            List<int> aListOfInt = new List<int>();
            aListOfInt.Add(4);
            aListOfInt.Add(12);
            aListOfInt.Add(9);

            // case 1
            Console.WriteLine("Case 1: Element with index 1 is {0}", aListOfInt[1]);

            // case 2
            Console.WriteLine("Case 2: List contains {0} elements", aListOfInt.Count);

            aListOfInt.Add(5);
            aListOfInt.Add(22);

            // case 3
            Console.WriteLine("Case 3: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.RemoveAt(0);

            // case 4
            Console.WriteLine("Case 4: Element with index 3 is {0}", aListOfInt[3]);

            aListOfInt.Clear();
            aListOfInt.Add(14);
            aListOfInt.Add(87);
            aListOfInt.Add(62);
            aListOfInt.Add(21);
            aListOfInt.Add(40);
            aListOfInt.Add(3);

            // case 5: add code that prints out all elements in the list
            Console.WriteLine("Start of case 5");
            foreach (int i in aListOfInt)
            {
                Console.WriteLine(i);
            }

            // case 6: add code that sums elements in list and prints result
            Console.WriteLine("Start of case 6");
            int sum6 = 0;
            foreach (int i in aListOfInt)
            {
                sum6 += i;
            }
            Console.WriteLine("Sum is: {0}", sum6);

            // case 7: add code to find average of elements in list and prints result
            // Tip: think about how average is defined. Then you might reuse pieces of 
            // case 6
            Console.WriteLine("Start of Case 7");
            int sum7 = 0;
            foreach (int i in aListOfInt)
            {
                sum7 += sum7;
            }
            int average = sum7 / aListOfInt.Count;
            Console.WriteLine("Average is: {0}", average);

            // case 8: add code to find smallest element in list and print result.
            // Tip: think about how you would do this manually
            Console.WriteLine("Start of Case 8");
            int smallest = aListOfInt[0];

            foreach (int i in aListOfInt)
            {
                if (i < smallest)
                {
                    smallest = i;
                }
            }
            Console.WriteLine("Smallest is: {0}", smallest);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise27
{
    class Runner
    {
        public void Run()
        {
            MathLibrarySolotion math = new MathLibrarySolotion();

            Console.WriteLine("Faculty(3), expected result : 6, got {0}", math.Faculty(3));
            Console.WriteLine("Faculty(8), expected result : 40320, got {0}", math.Faculty(8));
            Console.WriteLine("Faculty(1), expected result : 1, got {0}", math.Faculty(1));

            Console.WriteLine("IntervalSum(3,7), expected result : 25, got {0}", math.IntervalSum(3, 7));
            Console.WriteLine("IntervalSum(0,100), expected result : 5050, got {0}", math.IntervalSum(0, 100));
            Console.WriteLine("IntervalSum(7,2), expected result : 0, got {0}", math.IntervalSum(7, 2));

            Console.WriteLine("HighestSquareBelowLimit(20), expected result : 16, got {0}", math.HighestSquareBelowLimit(20));
            Console.WriteLine("HighestSquareBelowLimit(200), expected result : 196, got {0}", math.HighestSquareBelowLimit(200));
            Console.WriteLine("HighestSquareBelowLimit(-20), expected result : 0, got {0}", math.HighestSquareBelowLimit(-20));

            Console.WriteLine("IsPrime(20), expected result : False, got {0}", math.IsPrime(20));
            Console.WriteLine("IsPrime(41), expected result : True, got {0}", math.IsPrime(41));
            Console.WriteLine("IsPrime(103), expected result : True, got {0}", math.IsPrime(103));
            Console.WriteLine("IsPrime(91), expected result : False, got {0}", math.IsPrime(91));
        }
    }

    class MathLibrarySolotion
    {
        // method must return the faculty of n, also written n!
        // where n! = n x (n-1) x (n-2) x ... x 2 x 1
        // Example: the faculty of 4 is 4! = 4 x 3 x 2 x 1 = 24
        // Note: If n < 1, then the faculty is 1
        public int Faculty(int n)
        {
            // result holds final result
            int result = 1;

            // for all values from n down to (and including) 1
            for (int i = n; i >= 1; i--)
            {
                // result be multiplied by n, then (n-1), an so on
                result = result * i;
            }

            return result;
        }

        // method must return the sum of the numbers between
        // start and end.
        // Example: if start = 3 and end = 7, the interval sum is
        // 3 + 4 + 5 + 6 + 7 = 25;
        // Note: if start > end, the sum must be 0
        public int IntervalSum(int start, int end)
        {
            // result holds final result, i.e., the interval sum from start to end
            int result = 0;

            // for all values from start up to (and including) end
            for (int i = start; i <= end; i++)
            {
                // adds start, then (start + 1), and so on
                result = result + i; 
            }

            return result;
        }

        // method must return the highest square number below 
        // the limit provided.
        // Example: if the limit is 20, the highest square below the
        // limit is 16 (the square of 4) since the next square 
        // (the square of 5) is 25.
        // Note: if the limit is zero or negative, return 0
        public int HighestSquareBelowLimit(int limit)
        {
            // first check that limit is positive
            if (limit > 0)
            {
                // the number to be repeatedly squared 
                int value = 0;

                // check if next value (value + 1) keeps us
                // under the limit
                while ((value + 1) * (value + 1) < limit)
                {
                    // still under limit, so increase value
                    value++;
                }

                // since we've broken out of loop, the next value
                // would make us go over limit, so return.
                return (value * value);
            }
            else
            {
                // return zero if limit is negative or zero
                return 0;
            }
        }

        // Difficult.
        // Method must return true if providednumber is a prime number, 
        // otherwise it should return false.
        // Tip: A prime number can only be divded by 1 and itself, so
        // dividing it with any other number will leave a remainder
        // Note: Negative numbers aren't prime numbers
        public bool IsPrime(int n)
        {
            // all numbers below 2 aren't primes
            if (n < 2)
            {
                return false;
            }
            else
            {
                // assume n is a prime and try to disprove it
                bool isPrime = true;
                int value = 2;

                // for all values from 2 up to but not including n
                while (value < n)
                {
                    if ((n % value) == 0)
                    { 
                        // in other words, n is divisable by value which
                        // makes it non-prime
                        isPrime = false;
                    }
                    value++;
                }

                return isPrime;
            }
        }
    }
}

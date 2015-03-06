using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise27
{
    class MathLibrary
    {
        // method must return the faculty of n, also written n!
        // where n! = n x (n-1) x (n-2) x ... x 2 x 1
        // Example: the faculty of 4 is 4! = 4 x 3 x 2 x 1 = 24
        // Note: If n < 1, then the faculty is 1
        public int Faculty(int n)
        {
            // add implementation here
            return 0;
        }

        // method must return the sum of the numbers between
        // start and end.
        // Example: if start = 3 and end = 7, the interval sum is
        // 3 + 4 + 5 + 6 + 7 = 25;
        // Note: if start > end, the sum must be 0
        public int IntervalSum(int start, int end)
        {
            // add implementation here
            return 0;
        }

        // method must return the highest square number below 
        // the limit provided.
        // Example: if the limit is 20, the highest square below the
        // limit is 16 (the square of 4) since the next square 
        // (the square of 5) is 25.
        // Note: if the limit is zero or negative, return 0
        public int HighestSquareBelowLimit(int limit)
        {
            // add implementation here
            return 0;
        }

        // Difficult.
        // Method must return true if providednumber is a prime number, 
        // otherwise it should return false.
        // Tip: A prime number can only be divded by 1 and itself, so
        // dividing it with any other number will leave a remainder
        // Note: Negative numbers aren't prime numbers
        public bool IsPrime(int n)
        {
            // add implementation here
            return false;
        }
    }
}

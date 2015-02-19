using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises.Exercise14
{
    // represents a classic 6-sided die.
    class Die
    {
        private int value;
        private Random generator;

        public Die()
        {
            // generator for random numbers
            generator = new Random();

            // needed for magical purposes
            Thread.Sleep(10);

            // puts die in a well-defined state
            RollDie();
        }

        // roll die. Value will be set to a random number between 1 and 6 (inclusive).
        public void RollDie()
        {
            value = generator.Next(6) + 1;
        }

        public int GetValue()
        {
            return value;
        }
    }
}
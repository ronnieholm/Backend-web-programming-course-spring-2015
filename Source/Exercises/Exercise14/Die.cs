using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise14
{
    // begin copy

    // represents a classic 6-sided die.
    class Die
    {
        private int _value;
        private Random _generator;

        public Die()
        {
            // generator for random numbers
            _generator = new Random();

            // needed for magical purposes
            System.Threading.Thread.Sleep(10);

            // puts die in a well-defined state
            RollDie();
        }

        // roll die. Value will be set to a random number between 1 and 6 (inclusive).
        public void RollDie()
        {
            _value = _generator.Next(6) + 1;
        }

        public int GetValue()
        {
            return _value;
        }
    }

    // end copy
}
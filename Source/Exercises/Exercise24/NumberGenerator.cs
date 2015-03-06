using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise24
{
    // generates random numbers within a certain interval
    class NumberGenerator
    {
        private Random _generator;

        public NumberGenerator()
        {
            _generator = new Random();
        }

        // returns a random number between min and max
        public int GetRandomNumberInInterval(int min, int max)
        {
            int value = min + _generator.Next(max - min);
            return value;
        }
    }
}

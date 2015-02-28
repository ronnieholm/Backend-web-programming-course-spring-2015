using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise14
{
    // begin copy

    class DiceCup
    {
        private Die _die1;
        private Die _die2;

        public DiceCup()
        {
            // create actual objects in the constructor that the instance fields point to.
            _die1 = new Die();
            _die2 = new Die();
        }

        // you must create a method with the signature below
        // public void RollDice() { }

        // you must create a method with the signature below
        // public int GetTotalValue() { }

        // you must create a method with the signature below
        // public bool IsTotalValueLargerThan(int value) { }
    }

    // end copy
}

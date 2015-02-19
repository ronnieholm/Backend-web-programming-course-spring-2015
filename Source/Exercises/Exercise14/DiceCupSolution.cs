using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise14
{
    class DiceCup
    {
        private Die die1;
        private Die die2;

        public DiceCup()
        {
            // create actual objects in the constructor that the instance fields point to.
            die1 = new Die();
            die2 = new Die();
        }

        // you must create a method with the signature below
        // public void RollDice()

        // you must create a method with the signature below
        // public int GetTotalValue()

        // you must create a method with the signature below
        // public bool IsTotalValueLargerThan(int value)
    }
}

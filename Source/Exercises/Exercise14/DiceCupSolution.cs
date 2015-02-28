using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise14
{
    class MyCode
    {
        public void MyMain()
        {
            // 1
            Die d = new Die();
            Console.WriteLine(d.GetValue());

            d.RollDie();
            Console.WriteLine(d.GetValue());

            // 2a
            DiceCupSolution cup = new DiceCupSolution();
            cup.RollDice();

            // 2b
            Console.WriteLine(cup.GetTotalValue());

            // 2c
            Console.WriteLine(cup.IsTotalValueLargerThan(5));
        }
    }

    class DiceCupSolution
    {
        private Die _die1;
        private Die _die2;

        public DiceCupSolution()
        {
            // create actual objects in the constructor that the instance fields point to.
            _die1 = new Die();
            _die2 = new Die();
        }

        // you must create a method with the signature below
        public void RollDice()
        {
            _die1.RollDie();
            _die2.RollDie();
        }

        // you must create a method with the signature below
        public int GetTotalValue()
        {
            return _die1.GetValue() + _die2.GetValue();
        }

        // you must create a method with the signature below
        public bool IsTotalValueLargerThan(int value)
        {
            return GetTotalValue() > value;
        }
    }
}

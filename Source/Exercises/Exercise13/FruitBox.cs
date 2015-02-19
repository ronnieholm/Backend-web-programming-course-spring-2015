using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise13
{
    // begin copy

    // class represents a simple box of fruit and their price. It can only 
    // contain bananas and apples.
    class FruitBox
    {
        private int _numberOfBananas;
        private int _numberOfApples;
        private double _priceForOneBanana;
        private double _priceForOneApple;

        // creates the fruit box to be empty to start with but with specific item prices
        public FruitBox(double priceForOneBanana, double priceForOneApple)
        {
            _priceForOneBanana = priceForOneBanana;
            _priceForOneApple = priceForOneApple;
            _numberOfBananas = 0;
            _numberOfApples = 0;
        }

        public void AddApples(int numberOfApples)
        {
            _numberOfApples = _numberOfApples + numberOfApples;
        }

        public void AddBananas(int numberOfBananas)
        {
            _numberOfBananas = _numberOfBananas + numberOfBananas;
        }

        // returns a string describing the box content, but doesn't print anything on screen
        public string GetBoxContentDescription()
        {
            string description = "The box contains " + _numberOfBananas + " bananas and " + _numberOfApples + " apples";
            return description;
        }
    }

    // end copy
}

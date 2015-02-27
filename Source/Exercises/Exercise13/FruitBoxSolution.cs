using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise13
{
    class MyCode
    {
        public void MyMain()
        {
            // 2a
            FruitBoxSolution f = new FruitBoxSolution(1.99, 2.99);

            // 2b
            Console.WriteLine(f.GetBoxContentDescription());

            // 2c
            f.AddApples(3);
            f.AddBananas(5);

            // 2d
            Console.WriteLine(f.GetBoxContentDescription());

            // 3
            Console.WriteLine(f.GetTotalPrice());

            // 4
            f.SetPriceForOneApple(9);
            f.SetPriceforOneBanana(10);
            Console.WriteLine(f.GetTotalPrice());
        }
    }

    // class represents a simple box of fruit and their price. It can only 
    // contain bananas and apples.
    class FruitBoxSolution
    {
        private int _numberOfBananas;
        private int _numberOfApples;
        private double _priceForOneBanana;
        private double _priceForOneApple;

        // creates the fruit box to be empty to start with but with specific item prices
        public FruitBoxSolution(double priceForOneBanana, double priceForOneApple)
        {
            _priceForOneBanana = priceForOneBanana;
            _priceForOneApple = priceForOneApple;
            _numberOfBananas = 0;
            _numberOfApples = 0;
        }

        // 3
        public double GetTotalPrice()
        {
            return _numberOfBananas * _priceForOneBanana +
                   _numberOfApples * _priceForOneApple;
        }

        // 4
        public void SetPriceForOneApple(double price)
        {
            _priceForOneApple = price;
        }

        // 4
        public void SetPriceforOneBanana(double price)
        {
            _priceForOneBanana = price;
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
}

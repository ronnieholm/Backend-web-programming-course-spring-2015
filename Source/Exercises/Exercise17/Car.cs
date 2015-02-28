using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise17
{
    // begin copy

    public class Runner
    {
        public void Run()
        {
            Car car1 = new Car("Volvo", "V60", 165.0, 15.8, 5, true);
            Car car2 = new Car("BMW", "318i", 143.0, 18.2, 4, false);
            Car car3 = new Car("Skoda", "Fabia", 110.0, 19.8, 5, true);

            Console.WriteLine("The {0} {1} is a family car : {2}", car1.GetBrand(), car1.GetModelName(), car1.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car1.GetBrand(), car1.GetModelName(), car1.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car1.GetBrand(), car1.GetModelName(), car1.RentalPricePerDay());
            Console.WriteLine();

            Console.WriteLine("The {0} {1} is a family car : {2}", car2.GetBrand(), car2.GetModelName(), car2.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car2.GetBrand(), car2.GetModelName(), car2.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car2.GetBrand(), car2.GetModelName(), car2.RentalPricePerDay());
            Console.WriteLine();

            Console.WriteLine("The {0} {1} is a family car : {2}", car3.GetBrand(), car3.GetModelName(), car3.IsFamilyCar());
            Console.WriteLine("The {0} {1} is an economic car : {2}", car3.GetBrand(), car3.GetModelName(), car3.IsEconomic());
            Console.WriteLine("The {0} {1} has an rental price of : {2}  kr. per day", car3.GetBrand(), car3.GetModelName(), car3.RentalPricePerDay());
        }
    }

    public class Car
    {
        private string _brand;
        private string _modelName;
        private double _horsePower;
        private double _kmPerLiter;
        private int _numberOfSeats;
        private bool _hasAirCondition;

        // constructor creates a Car object with instance fields set using values provided in parameter list.
        public Car(string brand, string modelName, double horsePower, double kmPerLiter, int numberOfSeats, bool hasAirCondition)
        {
            _brand = brand;
            _modelName = modelName;
            _horsePower = horsePower;
            _kmPerLiter = kmPerLiter;
            _numberOfSeats = numberOfSeats;
            _hasAirCondition = hasAirCondition;
        }

        // returns brand of car
        public string GetBrand()
        {
            return _brand;
        }

        // returns model name of car
        public string GetModelName()
        {
            return _modelName;
        }

        // returns horse power of car
        public double GetHorsePower()
        {
            return _horsePower;
        }

        // returns number of kilometers car can drive per liter
        public double GetKmPerLiter()
        {
            return _kmPerLiter;
        }

        // returns number of seats in car
        public double GetSetCount()
        {
            return _numberOfSeats;
        }

        // returns whether car has air conditioning
        public bool HasAirCondition()
        {
            return _hasAirCondition;
        }

        // returns whether car is considered economic.
        // Do we really need if statement here?
        public bool IsEconomic()
        {
            bool isEconomic = false;

            if (_kmPerLiter > 18.0)
            {
                isEconomic = true;
            }

            return isEconomic;
        }

        // returns whether car is considered a family car.
        // Do we need two if statements here?
        public bool IsFamilyCar()
        {
            bool familyCar = false;

            if (_numberOfSeats >= 4)
            {
                if (_hasAirCondition)
                {
                    familyCar = true;
                }
            }

            return familyCar;
        }

        // returns suggested rental price (per day) for car.
        // Could something go wrong here?
        public int RentalPricePerDay()
        {
            int rentalPrice = 0;

            if (_horsePower < 70.0)
            {
                rentalPrice = 400;
            }

            if ((_horsePower > 70.0) && (_horsePower < 120.0))
            {
                rentalPrice = 550;
            }

            if ((_horsePower > 120.0) && (_horsePower < 200.0))
            {
                rentalPrice = 700;
            }

            if (_horsePower > 200.0)
            {
                rentalPrice = 1000;
            }

            return rentalPrice;
        }
    }

    // end copy
}

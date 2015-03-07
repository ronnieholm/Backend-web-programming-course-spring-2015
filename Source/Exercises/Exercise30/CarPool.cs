using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise30
{
    class Runner
    {
        public void Run()
        {
            CarPool pool = new CarPool();

            pool.AddCarToPool(new Car("CF 32 556", "Ford", "Mondeo"));
            pool.AddCarToPool(new Car("AG 57 109", "Ford", "Fiesta"));
            pool.AddCarToPool(new Car("DE 44 006", "BMW", "320i"));

            // pool should contain the three cars as per above
            Console.WriteLine("The Car Pool now contains:");
            pool.PrintAllCarsInPool();
            Console.WriteLine();

            pool.RemoveCarFromPool("AG 57 109");
            pool.RemoveCarFromPool("DOES NOT EXIST");

            // pool should contain two cars
            Console.WriteLine("The pool now contains:");
            pool.PrintAllCarsInPool();
            Console.WriteLine();
        }
    }

    class CarPool
    {
        // instance field which ise license pates as key and Car objects as value
        Dictionary<string, Car> _cars;

        public CarPool()
        {
            _cars = new Dictionary<string, Car>();
        }

        // add car to car pool
        public void AddCarToPool(Car car)
        {
            // add code here
        }

        // remove car with provided license plate from car pool. If license plate 
        // doesn't exist, do nothing
        public void RemoveCarFromPool(string licensePlate)
        {
            // add code here
        }

        // returns car object corresponding to provided license plate. Otherwise null
        public Car LookupCar(string licensePlate)
        {
            // add code here
            return null;
        }

        // prints all cars in pool (leave as is)
        public void PrintAllCarsInPool()
        {
            foreach (KeyValuePair<string, Car> kvp in _cars)
            {
                Car car = kvp.Value;
                Console.WriteLine("{0} is a {1} {2}", car.GetLicensePlate(), car.GetBrand(), car.GetModel());
            }
        }
    }
}

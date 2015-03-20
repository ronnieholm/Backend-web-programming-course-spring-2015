using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise30
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Exercises.Exercise30
    {
        class RunnerSolution
        {
            public void Run()
            {
                CarPoolSolution pool = new CarPoolSolution();

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

        class CarPoolSolution
        {
            // instance field which ise license pates as key and Car objects as value
            Dictionary<string, Car> _cars;

            public CarPoolSolution()
            {
                _cars = new Dictionary<string, Car>();
            }

            // add car to car pool
            public void AddCarToPool(Car car)
            {
                // add code here
                _cars.Add(car.GetLicensePlate(), car);
            }

            // remove car with provided license plate from car pool. If license plate 
            // doesn't exist, do nothing
            public void RemoveCarFromPool(string licensePlate)
            {
                // add code here
                if (_cars.ContainsKey(licensePlate))
                {
                    _cars.Remove(licensePlate);
                }
            }

            // returns car object corresponding to provided license plate. Otherwise null
            public Car LookupCar(string licensePlate)
            {
                // add code here
                if (_cars.ContainsKey(licensePlate))
                {
                    return _cars[licensePlate];
                }
                else
                {
                    return null;
                }
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

}

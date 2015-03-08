using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise35
{
    class Runner
    {
        public void Run()
        {
            List<int> integers = new List<int>();
            integers.Add(23);
            integers.Add(86);
            integers.Add(51);
            integers.Add(11);
            integers.Add(39);

            ListMethods lm = new ListMethods();

            int smallest = lm.FindSmallestNumber(integers);
            Console.WriteLine("The smallest number in the list is: {0}", smallest);

            int average = lm.FindAverage(integers);
            Console.WriteLine("The average of the list is: {0}", average);
        }
    }

    class ListMethods
    {
        public int FindSmallestNumber(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                int smallest = numbers[0];
                for (int index = 1; index < numbers.Count; index++)
                {
                    if (numbers[index] < smallest)
                    {
                        smallest = numbers[index];
                    }
                }
                return smallest;
            }
        }

        public int FindAverage(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException();
            }
            else
            {
                int sum = numbers[0];
                for (int index = 1; index < numbers.Count; index++)
                {
                    sum = sum + numbers[index];
                }
                return (sum / numbers.Count);
            }
        }
    }

    class Car
    {
        private string _licensePlate;
        private int _price;

        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
        }

        public string GetLicensePlate()
        {
            return _licensePlate;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}

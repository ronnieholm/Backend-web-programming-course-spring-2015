using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise35
{
    class RunnerSolution
    {
        public void Run()
        {
            List<int> integers = new List<int>();
            integers.Add(23);
            integers.Add(86);
            integers.Add(51);
            integers.Add(11);
            integers.Add(39);

            int smallest = ListMethodsSolution.FindSmallestNumber(integers);
            Console.WriteLine("The smallest number in the list is: {0}", smallest);

            int average = ListMethodsSolution.FindAverage(integers);
            Console.WriteLine("The average of the list is: {0}", average);

            CarSolution c1 = new CarSolution("ab12345", 100);
            CarSolution c2 = new CarSolution("zy54321", 200);

            c1.GetLicensePlate();
            c2.GetLicensePlate();

            c1.GetPrice();
            c2.GetPrice();

            CarSolution.PrintUsageStatistics();
        }
    }

    static class ListMethodsSolution
    {
        public static int FindSmallestNumber(List<int> numbers)
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

        public static int FindAverage(List<int> numbers)
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

    class CarSolution
    {
        private string _licensePlate;
        private int _price;

        private static int _carSolutionCalls = 0;
        private static int _getLicensePlateCalls = 0;
        private static int _getPriceCalls = 0;

        public CarSolution(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            _carSolutionCalls++;
        }

        public string GetLicensePlate()
        {
            _getLicensePlateCalls++;
            return _licensePlate;
        }

        public int GetPrice()
        {
            _getPriceCalls++;
            return _price;
        }

        public static void PrintUsageStatistics()
        {
            Console.WriteLine(
                "carSolutionCalls: {0}, getLicensePlateCalls: {1}, getPriceCalls: {2}",
                _carSolutionCalls, _getLicensePlateCalls, _getPriceCalls);
        }
    }
}

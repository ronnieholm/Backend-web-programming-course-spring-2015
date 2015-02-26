using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise22
{
    // begin copy

    class Runner
    {
        public void Run()
        {
            CubeCalculator cc = new CubeCalculator();

            string userInput = cc.GetUserInput("Please enter an integer number:");
            if (cc.IsANumber(userInput))
            {
                int value = cc.ConvertToNumber(userInput);
                int result = cc.CalculateCube(value);
                Console.WriteLine("The cube of {0} is {1}", value, result);
            }
            else
            {
                Console.WriteLine("Could not calculate");
            }
        }
    }

    class CubeCalculator
    {
        // reads user's input from console
        public string GetUserInput(string helpText)
        {
            Console.Write(helpText + " ");
            string userInput = Console.ReadLine();
            return userInput;
        }

        // checks if given string can be converted to an integer
        public bool IsANumber(String userInput)
        {
            try
            {
                Int32.Parse(userInput);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        // converts given string to integer
        public int ConvertToNumber(string userInput)
        {
            return Int32.Parse(userInput);
        }

        // calculates cube of given integer
        public int CalculateCube(int value)
        {
            return value * value * value;
        }
    }

    // end copy
}

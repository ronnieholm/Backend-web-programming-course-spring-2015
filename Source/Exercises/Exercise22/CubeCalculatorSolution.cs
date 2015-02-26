using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise22
{
    class SolutionRunner
    {
        public void Run()
        {
            CubeCalculator cc = new CubeCalculator();

            string userInput = "";
            do
            {
                userInput = cc.GetUserInput("Please enter a number (or q for quit): ");
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
            } while (userInput != "q");
        }
    }

    // CubeCalcular class idential to class in CubeCalculator.cs
}

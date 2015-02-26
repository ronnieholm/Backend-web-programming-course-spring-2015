using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise20
{
    class Runner
    {
        public void Run()
        {
            BodyAnalyzerSolution b = new BodyAnalyzerSolution();
            Console.WriteLine(b.CalculateBodyMassIndex(1.88, 110));
            Console.WriteLine(b.AnalyzeBodyMassIndex(1.88, 40));
            Console.WriteLine(b.AnalyzeBodyMassIndex(1.88, 75));
            Console.WriteLine(b.AnalyzeBodyMassIndex(1.88, 90));
            Console.WriteLine(b.AnalyzeBodyMassIndex(1.88, 110));
            Console.WriteLine(b.AnalyzeBodyMassIndex(1.88, 130));
        }
    }

    class BodyAnalyzerSolution
    {
        // given weight and height of person, returns Body Mass Index
        public double CalculateBodyMassIndex(double heightInMeters, double weightInKilo)
        {
            double bmi = weightInKilo / (heightInMeters * heightInMeters);
            return bmi;
        }

        // given weight and height of person, returns brief analyzis
        public string AnalyzeBodyMassIndex(double heightInMeters, double weightInKilo)
        {
            double bmi = CalculateBodyMassIndex(heightInMeters, weightInKilo);
            string analysis = "Your BMI is : " + bmi + ", ";

            if (bmi < 15)
            {
                analysis += "You are way too skinny!";
                analysis = analysis + "You ...";
            }
            else if (bmi >= 15 && bmi <= 22)
            {
                analysis += "You are a bit skinny";
            }
            else if (bmi > 22 && bmi <= 28)
            {
                analysis += "You are just fine!";
            }
            else if (bmi > 28 && bmi <= 35)
            {
                analysis += "You are a bit overweight!";
            }
            else
            {
                analysis += "You are way too fat!";
            }

            return analysis;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise20
{
    // begin copy

    class BodyAnalyzer
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
            // the below code must be changed
            string analysis = "All people are beautiful, You are beautiful";
            return analysis;
        }
    }

    // end copy
}

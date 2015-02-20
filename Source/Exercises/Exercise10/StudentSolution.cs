using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise10
{
    class MyRunner
    {
        public void MyCodeSolution()
        {
            // this code can either be called from Main or be pasted into Main

            // 2a
            StudentSolution s = new StudentSolution("John Doe", "Denmark");

            // 2b
            s.AddTestScore(10);
            s.AddTestScore(20);
            s.AddTestScore(30);

            // 2c
            Console.WriteLine(s.GetName());
            Console.WriteLine(s.GetAverageTestScore());

            // 4
            Console.WriteLine(s.GetCountry());
        }
    }

    class StudentSolution
    {
        private int[] testScores;
        private int noOfTestsTaken;
        private string name;

        // 3a
        private string country;

        // Creates a Student object with the provided name
        // The number of tests is initially 0 (zero)
        // 3b
        public StudentSolution(string name, string country)
        {
            this.name = name;
            this.country = country;
            noOfTestsTaken = 0;
            testScores = new int[50];
        }

        // 3c
        public string GetCountry()
        {
            return country;
        }

        // Add a single test score. A score is a number between
        // 0 and 100
        public void AddTestScore(int score)
        {
            testScores[noOfTestsTaken] = score;
            noOfTestsTaken++;
        }

        // Return the name of the student
        public String GetName()
        {
            return name;
        }

        // Return the number of tests the student has taken
        public int GetNumberOfTestsTaken()
        {
            return noOfTestsTaken;
        }

        // Calculate and return the average value of the scores 
        // for the tests the student has taken
        public int GetAverageTestScore()
        {
            if (noOfTestsTaken == 0)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                for (int index = 0; index < noOfTestsTaken; index++)
                {
                    sum = sum + testScores[index];
                }
                int average = sum / noOfTestsTaken;

                return average;
            }
        }
    }
}

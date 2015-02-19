using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise10
{
    // begin copy

    class Student
    {
        private int[] _testScores;
        private int _noOfTestsTaken;
        private string _name;

        // creates Student object with the provided name, number of tests set to zero,
        // and with the ability to store 50 test scores.
        public Student(string name)
        {
            _name = name;
            _noOfTestsTaken = 0;
            _testScores = new int[50];
        }

        // adds a single test score which is a number between 0 and 100
        public void AddTestScore(int score)
        {
            _testScores[_noOfTestsTaken] = score;
            _noOfTestsTaken++;
        }

        // returns name of student
        public String GetName()
        {
            return _name;
        }

        // returns number of tests student has taken
        public int GetNumberOfTestsTaken()
        {
            return _noOfTestsTaken;
        }

        // calculates and return average value of scores for tests student has taken
        public int GetAverageTestScore()
        {
            if (_noOfTestsTaken == 0)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                for (int index = 0; index < _noOfTestsTaken; index++)
                {
                    sum = sum + _testScores[index];
                }
                int average = sum / _noOfTestsTaken;
                return average;
            }
        }
    }

    // end copy
}

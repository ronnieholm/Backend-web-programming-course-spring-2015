﻿using System;
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
        private int[] _testScores;
        private int _noOfTestsTaken;
        private string _name;

        // 3a
        private string _country;

        // creates Student object with the provided name, number of tests set to zero,
        // and with the ability to store 50 test scores.
        // 3b
        public StudentSolution(string name, string country)
        {
            _name = name;
            _country = country;
            _noOfTestsTaken = 0;
            _testScores = new int[50];
        }

        // 3c
        public string GetCountry()
        {
            return _country;
        }

        // adds a single test score which is imagine to be a number between 0 and 100
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
}

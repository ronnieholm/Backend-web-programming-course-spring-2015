using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise31
{
    class Student
    {
        private int _id;
        private string _name;
        private Dictionary<string, int> _testScores;

        // created student with fixed id and name
        public Student(int id, String name)
        {
            _name = name;
            _id = id;
            _testScores = new Dictionary<string, int>();
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        // adds a single course/test score
        public void AddTestResult(string course, int score)
        {
            _testScores.Add(course, score);
        }

        // find average test scores for student. If no scores are present
        // an average of 0 is returned.
        public int GetScoreAverage()
        {
            if (_testScores.Count == 0)
            {
                return 0;
            }
            else
            {
                int sum = 0;
                foreach (KeyValuePair<String, int> kvp in _testScores)
                {
                    sum += kvp.Value;
                }
                return sum / _testScores.Count;
            }
        }
    }
}

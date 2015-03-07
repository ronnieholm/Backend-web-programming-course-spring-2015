using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise31
{
    class RunnerSolution
    {
        public void Run()
        {
            StudentCollectionSolution students = new StudentCollectionSolution();

            Student anna = new Student(12, "Anna");
            Student betty = new Student(338, "Betty");
            Student carl = new Student(92, "Carl");

            anna.AddTestResult("English", 85);
            anna.AddTestResult("Math", 70);
            anna.AddTestResult("Biology", 90);
            anna.AddTestResult("French", 52);

            betty.AddTestResult("English", 77);
            betty.AddTestResult("Math", 82);
            betty.AddTestResult("Chemistry", 65);
            betty.AddTestResult("French", 41);

            carl.AddTestResult("English", 55);
            carl.AddTestResult("Math", 48);
            carl.AddTestResult("Biology", 70);
            carl.AddTestResult("French", 38);

            students.AddStudent(anna.GetId(), anna);
            students.AddStudent(betty.GetId(), betty);
            students.AddStudent(carl.GetId(), carl);

            // does output match you expectations?
            Console.WriteLine(students.GetStudentCount());
            Console.WriteLine(students.GetStudent(12).GetName());
            Console.WriteLine(students.GetStudent(338).GetName());
            Console.WriteLine(students.GetStudent(92).GetName());
            Console.WriteLine(students.GetAverageForStudent(12));
            Console.WriteLine(students.GetAverageForStudent(338));
            Console.WriteLine(students.GetAverageForStudent(92));
            Console.WriteLine(students.GetAverageForStudent(120));
            Console.WriteLine(students.GetTotalAverage());
        }
    }

    class StudentCollectionSolution
    {
        private Dictionary<int, Student> _students;

        public StudentCollectionSolution()
        {
            _students = new Dictionary<int, Student>();
        }

        // returns number of students in collection
        public int GetStudentCount()
        {
            // add code here
            return _students.Count;
        }

        // adds student to collections
        public void AddStudent(int id, Student student)
        {
            // add code here
            _students.Add(id, student);
        }

        // given a student id, returns student with that id.
        // If no student exists with id, return null
        public Student GetStudent(int id)
        {
            // add code here
            if (_students.ContainsKey(id))
            {
                return _students[id];
            }
            else
            {
                return null;
            }
        }

        // given a student id, return the average score for student with id.
        // If no student exists with the given id, return 0.
        public int GetAverageForStudent(int id)
        {
            // add code here
            if (_students.ContainsKey(id))
            {
                return _students[id].GetScoreAverage();
            }
            else
            {
                return 0;
            }
        }

        // calculate total test score average for all students.
        // Tip: use GetAllStudentIds and a loop.
        public int GetTotalAverage()
        {
            // add code here
            List<int> ids = GetAllStudentIds();
            int sum = 0;
            foreach (int id in ids)
            {
                sum += GetAverageForStudent(id);
            }

            return sum / ids.Count;
        }

        // returns all ids of students in collections (leave as is)
        public List<int> GetAllStudentIds()
        {
            // a bit of black magic
            return new List<int>(_students.Keys.ToArray());
        }
    }
}

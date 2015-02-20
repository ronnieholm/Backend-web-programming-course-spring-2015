using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise12
{
    class MyCode
    {
        public void MyMain()
        {
            // 2a
            StatusSolution s = new StatusSolution("In class");

            // 2b
            Console.WriteLine(s.GetStatusText());
            Console.WriteLine(s.GetNoOfLikes());
            Console.WriteLine(s.GetNoOfDislikes());

            // 2c
            s.AddOneLike();
            s.AddOneLike();
            s.AddOneDislike();

            // 2d
            Console.WriteLine(s.GetStatusText());
            Console.WriteLine(s.GetNoOfLikes());
            Console.WriteLine(s.GetNoOfDislikes());

            // 3e
            s.ReadStatus();
            s.ReadStatus();
            Console.WriteLine(s.GetNumberOfReads());

            // 4
            s.ReadStatusMultiple(5);
            Console.WriteLine(s.GetNumberOfReads());
        }
    }

    class StatusSolution
    {
        private string _statusText;
        private int _likes;
        private int _dislikes;

        // 3a
        private int numberOfReads;

        // creates the Status instance. Initially, status has zero likes and dislikes
        public StatusSolution(string statusText)
        {
            _statusText = statusText;
            _likes = 0;
            _dislikes = 0;

            // 3b
            numberOfReads = 0;
        }

        // 3c
        public void ReadStatus()
        {
            numberOfReads++;
        }

        // 3d
        public int GetNumberOfReads()
        {
            return numberOfReads;
        }

        // 4
        public void ReadStatusMultiple(int numberOfReads)
        {
            this.numberOfReads += numberOfReads;
        }

        public void AddOneLike()
        {
            _likes = _likes + 1;
        }

        public void AddOneDislike()
        {
            _dislikes = _dislikes + 1;
        }

        public string GetStatusText()
        {
            return _statusText;
        }

        public int GetNoOfLikes()
        {
            return _likes;
        }

        public int GetNoOfDislikes()
        {
            return _dislikes;
        }
    }
}

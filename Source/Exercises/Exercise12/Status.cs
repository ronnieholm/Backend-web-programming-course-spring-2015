using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise12
{
    class Status
    {
        private string _statusText;
        private int _likes;
        private int _dislikes;

        // creates the Status instance. Initially, status has zero likes and dislikes
        public Status(string statusText)
        {
            _statusText = statusText;
            _likes = 0;
            _dislikes = 0;
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

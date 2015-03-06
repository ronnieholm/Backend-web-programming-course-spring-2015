using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise24
{
    // implements a simple logging system where strings are individually
    // collected. The set of strings can then be printed.
    class BattleLog
    {
        List<string> _log;

        public BattleLog()
        {
            _log = new List<string>();
        }

        public void Save(string message)
        {
            _log.Add(message);
        }

        public void PrintEntireBattleLog()
        {
            Console.WriteLine("Battle log");
            Console.WriteLine("======================================");
            foreach (string s in _log)
            {
                Console.WriteLine(s);
            }
        }

        public void Reset()
        {
            _log.Clear();
        }
    }
}

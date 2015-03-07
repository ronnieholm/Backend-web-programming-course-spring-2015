using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise33
{
    abstract class Employee
    {
        private string _name;

        public Employee(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public abstract int GetSalaryPerMonth();
        public abstract int GetBonusPerMonth();
        public abstract bool IsBonusPaidOut();
    }
}

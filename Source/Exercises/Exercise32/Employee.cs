using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise32
{
    class Employee
    {
        private string _name;
        private int _salaryPerMonth;

        public Employee(string name, int salaryPerMonth)
        {
            _name = name;
            _salaryPerMonth = salaryPerMonth;
        }

        public string GetName()
        {
            return _name;
        }

        public virtual int GetSalaryPerMonth()
        {
            return _salaryPerMonth;
        }
    }
}

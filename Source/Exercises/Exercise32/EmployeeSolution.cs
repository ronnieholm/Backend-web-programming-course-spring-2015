using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise32
{
    // 1
    class EmployeeSolution
    {
        private string _name;
        private int _salaryPerMonth;

        public EmployeeSolution(string name, int salaryPerMonth)
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

    // 2
    class WorkerSolution : EmployeeSolution
    {
        private string _skill;

        public WorkerSolution(string name, int salaryPerMonth, string skill)
            : base(name, salaryPerMonth)
        {
            _skill = skill;
        }

        public String GetSkill()
        {
            return _skill;
        }

        public void SetSkill(String skill)
        {
            this._skill = skill;
        }
    }

    // 3
    class ManagerSolution : EmployeeSolution
    {
        private int _monthlyBonus;
        private int _hoursWorked;

        public ManagerSolution(string name, int salaryPerMonth, int monthlyBonus)
            : base(name, salaryPerMonth)
        {
            _monthlyBonus = monthlyBonus;
            _hoursWorked = 0;
        }

        public void SetHoursWorked(int hoursWorked)
        {
            _hoursWorked = hoursWorked;
        }

        public override int GetSalaryPerMonth()
        {
            int totalSalary = base.GetSalaryPerMonth();
            if (_hoursWorked > 180)
            {
                totalSalary += _monthlyBonus;
            }
            return totalSalary;
        }
    }

    // 4
    class DirectorSolution : ManagerSolution
    {
        public DirectorSolution(string name, int salaryPerMonth)
            : base(name, salaryPerMonth, 20000)
        {
        }
    }

    // 5
    class RunnerSolution
    {
        public void Run()
        {
            List<EmployeeSolution> employees = new List<EmployeeSolution>();

            WorkerSolution w1 = new WorkerSolution("James", 15000, "Maintenance");
            WorkerSolution w2 = new WorkerSolution("Irina", 17000, "Truck Driver");
            employees.Add(w1);
            employees.Add(w2);

            ManagerSolution m1 = new ManagerSolution("Johanna", 22000, 4000);
            ManagerSolution m2 = new ManagerSolution("James", 23000, 3000);
            m1.SetHoursWorked(190);
            m2.SetHoursWorked(160);
            employees.Add(m1);
            employees.Add(m2);

            DirectorSolution d1 = new DirectorSolution("Susan", 35000);
            DirectorSolution d2 = new DirectorSolution("Thomas", 38000);
            d1.SetHoursWorked(130);
            d2.SetHoursWorked(200);
            employees.Add(d1);
            employees.Add(d2);

            foreach (EmployeeSolution e in employees)
            {
                Console.WriteLine("{0} has a salary of {1}", e.GetName(), e.GetSalaryPerMonth());
            }
        }
    }
}

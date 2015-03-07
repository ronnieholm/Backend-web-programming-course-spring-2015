using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise33
{
    // 1 & 2
    abstract class EmployeeSolution
    {
        private string _name;

        public EmployeeSolution(string name)
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

    // 3 & 4
    class WorkerSolution : EmployeeSolution
    {
        private int _hourlyPay;
        private int _hoursWorked;

        public WorkerSolution(string name, int hourlyPay, int hoursWorked)
            : base(name)
        {
            _hourlyPay = hourlyPay;
            _hoursWorked = hoursWorked;
        }

        public override int GetSalaryPerMonth()
        {
            return _hourlyPay * _hoursWorked;
        }

        public override int GetBonusPerMonth()
        {
            return 0;
        }

        public override bool IsBonusPaidOut()
        {
            return false;
        }
    }

    // 5 & 6
    abstract class ManagerSolution : EmployeeSolution
    {
        private int _baseSalary;
        private int _monthlyBonus;

        public ManagerSolution(string name, int baseSalary, int monthlyBonus)
            : base(name)
        {
            _baseSalary = baseSalary;
            _monthlyBonus = monthlyBonus;
        }

        public override int GetSalaryPerMonth()
        {
            int totalSalary = _baseSalary;
            if (IsBonusPaidOut())
            {
                totalSalary += _monthlyBonus;
            }
            return totalSalary;
        }

        public override int GetBonusPerMonth()
        {
            return _monthlyBonus;
        }
    }

    // 7
    class JuniorManagerSolution : ManagerSolution
    {
        private int _hoursWorked;

        public JuniorManagerSolution(string name, int baseSalary, int monthlyBonus)
            : base(name, baseSalary, monthlyBonus)
        {
            _hoursWorked = 0;
        }

        public void SetHoursWorked(int hoursWorked)
        {
            _hoursWorked = hoursWorked;
        }

        public override bool IsBonusPaidOut()
        {
            return _hoursWorked > 180;
        }
    }

    // 8
    class SeniorManagerSolution : ManagerSolution
    {
        private int _performanceLevel;

        public SeniorManagerSolution(string name, int baseSalary, int monthlyBonus)
            : base(name, baseSalary, monthlyBonus)
        {
            _performanceLevel = 0;
        }

        public void SetPerformanceLevel(int performanceLevel)
        {
            _performanceLevel = performanceLevel;
        }

        public override bool IsBonusPaidOut()
        {
            return _performanceLevel >= 6;
        }
    }

    // 9
    class SolutionRunner
    {
        public void Run()
        {
            List<EmployeeSolution> employees = new List<EmployeeSolution>();

            WorkerSolution w1 = new WorkerSolution("John", 130, 130);
            WorkerSolution w2 = new WorkerSolution("Annie", 120, 160);
            employees.Add(w1);
            employees.Add(w2);

            JuniorManagerSolution j1 = new JuniorManagerSolution("Steve", 25000, 6000);
            j1.SetHoursWorked(140);
            JuniorManagerSolution j2 = new JuniorManagerSolution("Tanya", 23000, 8000);
            j2.SetHoursWorked(185);
            employees.Add(j1);
            employees.Add(j2);

            SeniorManagerSolution s1 = new SeniorManagerSolution("Sandra", 35000, 16000);
            s1.SetPerformanceLevel(7);
            SeniorManagerSolution s2 = new SeniorManagerSolution("Olav", 38000, 12000);
            s2.SetPerformanceLevel(5);
            employees.Add(s1);
            employees.Add(s2);

            foreach (EmployeeSolution e in employees)
            {
                Console.WriteLine("{0} has a salary of {1}", e.GetName(), e.GetSalaryPerMonth());
            }
        }
    }
}

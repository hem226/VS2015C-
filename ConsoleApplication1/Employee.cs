using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Employee
    {
        public int ID;
        public string Name;
        protected int Salary;

        public int EmpSalary
        {
            get
            {
                return Salary;
            }
            set
            {
                Salary = value;
            }
        }

        public virtual int GetYearlySalary()
        {
            return 14 * Salary;
        }
    }

    class Manager : Employee
    {
        public int Bonus;

        public override int GetYearlySalary()
        {
            return base.GetYearlySalary() + Bonus;
        }
    }
}
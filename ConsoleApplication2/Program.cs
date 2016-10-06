using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //Console.WriteLine(emp.Name);

            string str = "123";
            Console.WriteLine(str.IsNumber());
        }

        

        public class Employee
        {
            public int ID;
            public string Name;
            public int Salary;

            public virtual int GetYearlySalary()
            {
                return 14 * Salary;
            }

            public Employee() : this(0, "guest", 1000)
            {
                //ID = 0;
                //Name = "guest";
                //Salary = 1000;
            }

            public Employee(int i, string n, int s)
            {
                ID = i;
                Name = n;
                Salary = s;
            }

        }
    }

    static class QQQ
    {
        public static bool IsNumber(this string s)
        {
            int a;
            bool result = int.TryParse(s, out a);
            return result;
        }
    }

}

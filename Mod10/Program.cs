using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manager m = new Manager() { ID=1, Salary=1000 , Bonus=1000 };
            //Sales s = new Sales() { ID=2 , Salary=1000 , CustomerCount=10};

            //Console.WriteLine(m.GetYearlySalary());
            //Console.WriteLine(s.GetYearlySalary());

            //Employee e = new Employee();
            //e.Salary = 600;

            //Employee e = new Manager();


            //List<IClassInfo> iList = new List<IClassInfo>() {
            //    new MyMath(),
            //    new Sales()
            //};

            //foreach (IClassInfo item in iList)
            //{
            //    Console.WriteLine(item.GetClassInfo());
            //}


            List<Manager> emplist = new List<Manager>()
            {
                new Manager(){ ID=3,Salary=1000,Bonus=1000 },
                new Manager(){ ID=1,Salary=1000,Bonus=1100 },
                new Manager(){ ID=5,Salary=1000,Bonus=1500 },
                new Manager(){ ID=2,Salary=1000,Bonus=900 }
            };
            emplist.Sort();
            foreach (Manager item in emplist)
            {
                Console.WriteLine(string.Format(
                    "ID:{0}  ,Salary:{1}  ,Bonus:{2}",
                    item.ID, item.Salary, item.Bonus));
            }
        }
    }

    abstract class Employee
    {

        public int ID;
        public int Salary;
        public abstract int GetYearlySalary();
    }

    class Manager : Employee, IComparable<Manager>
    {
        public int Bonus;

        public int CompareTo(Manager other)
        {
            // >0 自己比較大
            // <0 別人比較大
            // =0 一樣大

            //this.ID   
            //other.ID

            return other.ID - this.ID;
        }

        public override int GetYearlySalary()
        {
            return Salary * 14 + Bonus;
        }
    }

    class Sales : Employee, IClassInfo
    {
        public int CustomerCount;

        public override int GetYearlySalary()
        {
            return Salary * 13 + CustomerCount * 100;
        }

        public string GetClassInfo()
        {
            return "這是一個儲存業務資訊的類別";
        }
    }

    class MyMath : IClassInfo
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public string GetClassInfo()
        {
            return "這是一個數學計算類別";
        }
    }

    interface IClassInfo
    {
        string GetClassInfo();
    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //string str = "Hello World!!";
            //Console.WriteLine(str);

            //FileStream fs = new FileStream("test.txt", FileMode.Create, FileAccess.Write);

            //StreamWriter sw = new StreamWriter(fs);

            //int[] a = { 1, 2, 3, 4, 5 };

            //ArrayList ary = new ArrayList() { 10, 20, 3, 4, 5 };

            //ary.Sort();
            //ary.Remove(3);


            //List<int> ary2 = new List<int>() { 5, 6, 8, 789, 231, 321 };


            //ary.Add(1);
            //ary.Add(2);
            //ary.Add(3);
            //ary.Add(4);
            //ary.Add(55);

            //for (int i = 0; i < a.Length; i++)
            //{
            //    sw.WriteLine(a[i]);
            //}

            //if (!ary.Contains(55))
            //{
            //    ary.Add(55);
            //}

            //Console.WriteLine("Array1");
            //foreach (var item in ary)
            //{
            //    Console.WriteLine(item);
            //    //sw.WriteLine(item);


            //}
            //Console.WriteLine("Array1: " + ary.IndexOf(55));


            //Console.WriteLine("Array2");

            //foreach (var item in ary2)
            //{
            //    Console.WriteLine(item);
            //}


            //sw.Close();
            //fs.Close();

            //string name = Console.ReadLine();

            //switch (name)
            //{
            //    case "admin":
            //        Console.WriteLine("admin");
            //        break;
            //    case "aaa":
            //    case "bbb":
            //        Console.WriteLine("aaabbb");
            //        break;
            //    default:
            //        Console.WriteLine("other");
            //        break;
            //}

            //Console.WriteLine("Input Number: ");

            //Random rdm = new Random();
            //int intRandom = rdm.Next(1, 10);
            //int? intInput = null;

            //do
            //{
            //    string strInput = Console.ReadLine();
            //    intInput = Convert.ToInt32(strInput);
            //    if(intRandom == intInput)
            //    {
            //        break;
            //    }

            //} while (true);

            //Console.WriteLine("GoodJob!!");

            //List<int> lottoAry = new List<int>();
            //Random rnd = new Random();

            //while (true)
            //{
            //    int number = rnd.Next(1, 50);
            //    if (lottoAry.Contains(number))
            //    {
            //        continue;
            //    }

            //    lottoAry.Add(number);

            //    if(lottoAry.Count == 6)
            //    {
            //        break;
            //    }

            //}

            //lottoAry.Sort();
            //foreach (var item in lottoAry)
            //{
            //    Console.WriteLine(item);
            //    System.Threading.Thread.Sleep(600);
            //}

            //add(5, 5);

            //string s = Console.ReadLine();
            //int x = 1;
            //PassByVal(x);
            //PassByRef(ref x);
            //Console.WriteLine(x);

            //bool ss = int.TryParse(s, out a);
            //PassByOut(out s);
            //Console.WriteLine(s);
            //add(5, 1);
            //string a = "1111";
            //string b = "2222";

            //string s = string.Format("AAAAAAAAAAA{0},BBBBBBBB{1}", a ,b);

            //Employee emp = new Employee();
            //emp.ID = 1;
            //emp.Name = "Test";
            //emp.Salary = 1111;

            //Console.WriteLine(emp.Name);

            #endregion

            //List<Employee> empList = new List<Employee>() {
            //    new Employee { ID = 3, Name = "List", EmpSalary = 1300 },
            //    new Employee { ID = 3, Name = "List2", EmpSalary = 1400 },
            //    new Employee { ID = 5, Name = "List3", EmpSalary = 1500 }
            //};



            //Employee emp = new Employee() { ID = 1, Name = "test", Salary = 1000 };
            //Employee emp2 = new Employee() { ID = 2, Name = "asdf", Salary = 1100 };

            //empList.Add(new Employee { ID = 3, Name = "List", Salary = 1300 });
            //empList.Add(new Employee { ID = 4, Name = "List2", Salary = 1400 });
            //empList.Add(new Employee { ID = 5, Name = "List3", Salary = 1500 });

            //Console.WriteLine(emp.Name);
            //Console.WriteLine(emp2.Name);

            //foreach (var item in empList)
            //{
            //    Console.WriteLine(string.Format("Name: {0}, Salary: {1}",item.Name, item.EmpSalary));
            //}

            //Console.WriteLine(empList[0].Name + " " + empList[1].Name + " " + empList[2].Name);

            //ClassA a = new ClassA();
            //Employee e = new Employee() { ID = 4, Name = "Manager", EmpSalary = 1000 };
            //Employee e2 = new Manager() { ID = 4, Name = "Manager", EmpSalary = 1000, Bonus = 1000 };

            //Console.WriteLine(string.Format("Name: {0}, Salary: {1}, YearlySalary: {2}", e.Name, e.EmpSalary, e.GetYearlySalary()));
            //Console.WriteLine(string.Format("Name: {0}, Salary: {1}, YearlySalary: {2}", e2.Name, e2.EmpSalary, e2.GetYearlySalary()));

            #region 異質集合
            //List<Employee> empList = new List<Employee>()
            //{
            //    new Employee(){ ID = 1, Name = "Tony" , EmpSalary = 1000 },
            //    new Employee(){ ID = 2, Name = "Andy" , EmpSalary = 1000 },
            //    new Employee(){ ID = 3, Name = "Mary" , EmpSalary = 1000 },
            //    new Manager(){ ID= 4, Name= "John" , EmpSalary = 1000, Bonus= 1000 },
            //    new Manager(){ ID= 5, Name= "Alex" , EmpSalary = 1000, Bonus= 2000 },
            //    new Manager(){ ID= 6, Name= "Adam" , EmpSalary = 1000, Bonus= 3000 },
            //};

            //foreach (Employee item in empList)
            //{
            //    string str = string.Format(
            //        "編號:{0},姓名:{1},年薪{2}",
            //        item.ID,
            //        item.Name,
            //        item.GetYearlySalary());

            //    Console.WriteLine(str);
            //}

            //List<Manager> manList = new List<Manager>()
            //{
            //    new Manager(){ ID= 4, Name= "John" , EmpSalary = 1000, Bonus= 1000 },
            //    new Manager(){ ID= 5, Name= "Alex" , EmpSalary = 1000, Bonus= 2000 },
            //    new Manager(){ ID= 6, Name= "Adam" , EmpSalary = 1000, Bonus= 3000 },
            //};

            //foreach (Manager item in manList)
            //{
            //    string str = string.Format(
            //        "編號:{0},姓名:{1},年薪{2}",
            //        item.ID,
            //        item.Name,
            //        item.GetYearlySalary());

            //    Console.WriteLine(str);
            //}

            #endregion

            //Employee emp = new Employee() { ID = 1, Name = "Tony" };
            //Employee emp2 = emp;

            //Console.WriteLine(emp == emp2);

            #region is運算子
            //Employee emp = new Employee() { ID = 1, Name = "Tony" };
            //Console.WriteLine(emp is Manager);
            //Console.WriteLine(emp is Employee);
            //Console.WriteLine(emp is object);

            //object man = new Manager() { ID = 1, Name = "Tony", Bonus = 500 };
            //Console.WriteLine(man is Manager);
            //Console.WriteLine(man is Employee);
            //Console.WriteLine(man is object);
            #endregion

            #region as運算子
            Employee emp = new Employee() { ID = 1, Name = "Tony" };
            //Employee emp = new Manager() { ID = 1, Name = "Tony", Bonus = 1000 };

            //Manager man = (Manager)emp; //強制轉型
            Manager man = emp as Manager;  //回傳null

            if (man != null)
            {
                Console.WriteLine(man.GetYearlySalary());
            }
            #endregion
        }

        #region
        static void add(int a, int b)
        {
            int tt = a + b;
            Console.WriteLine(tt);
        }

        static void add(int a)
        {
            int tt = a + 6;
            Console.WriteLine(tt);
        }

        static void PassByVal(int i)
        {
            i += 4;
        }

        static void PassByRef(ref int i)
        {
            i += 4;
        }

        static void PassByOut(out int i)
        {
            i = 5;
        }
        #endregion
    }

    //class Employee
    //{
    //    public int ID;
    //    public string Name;
    //    public int Salary;

    //    public int GetYearlySalary()
    //    {
    //        return 14 * Salary;
    //    }
    //}

    partial class ClassA
    {
        public int aa { get; set; }
    }
}

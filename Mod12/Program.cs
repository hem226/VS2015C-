using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region delegate
            //SayHelloDelegate d = new SayHelloDelegate(SayHello);
            ////d.Invoke("tony");
            //d("tony");

            //SayHelloDelegate d = new SayHelloDelegate(SayHello);
            //d +=  new SayHelloDelegate(SayHi);
            //d +=  new SayHelloDelegate(SayHi);
            //d.Invoke("tony"); 
            #endregion

            #region Comparison
            //List<Employee> emplist = new List<Employee>(){
            //    new Employee() { ID = 2, Name = "Tony", Salary = 1000 },
            //    new Employee() { ID = 1, Name = "Bob", Salary = 1200 },
            //    new Employee() { ID = 3, Name = "Mary", Salary = 1100 }
            //};

            //emplist.Sort(new Comparison<Employee>(QQ));

            //foreach (Employee item in emplist)
            //{
            //    Console.WriteLine(item.ID);
            //}
            #endregion

            LottoClass lo = new LottoClass();

            //5
            //lo.GenNumberEvent += Lo_GenNumberEvent;
            lo.GenNumberEvent += new LottoClass.GenNumberHandler(Lo_GenNumberEvent);

            List<int> lList = lo.GenLottoNumbers();


            foreach (int item in lList)
            {
                Console.WriteLine(item);
            }
        }

        private static void Lo_GenNumberEvent(int number)
        {
            Console.WriteLine("號碼: " + number.ToString());
        }

        //1
        static void PrintNumber(int number)
        {

        }


        static int QQ(Employee a, Employee b)
        {
            return a.Salary - b.Salary;
        }

        delegate void SayHelloDelegate(string name);
        static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }

    public class Employee
    {
        public int ID;
        public string Name;
        public int Salary;
    }

    class LottoClass
    {
        //2
        public delegate void GenNumberHandler(int number);
        //3
        public event GenNumberHandler GenNumberEvent;

        public List<int> GenLottoNumbers()
        {
            Random rnd = new Random();
            List<int> lottoList = new List<int>();

            while (true)
            {
                System.Threading.Thread.Sleep(1500);

                int number = rnd.Next(1, 50);

                if (lottoList.Contains(number) == true)
                {
                    continue;
                }

                lottoList.Add(number);

                //4 觸發事件
                if (GenNumberEvent != null)
                {
                    GenNumberEvent(number);
                }

                if (lottoList.Count == 6)
                {
                    break;
                }
            }

            lottoList.Sort();

            return lottoList;
        }
    }
}

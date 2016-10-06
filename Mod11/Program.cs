using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11
{
    class Program
    {
        static void Main(string[] args)
        {
            //strng a = "AA";

            //string str = Console.ReadLine();
            //int.Parse(str);


            //int a = 6;

            //int b = 6;

            //int total = 0;

            //total = Add(a, b);

            //Console.WriteLine("總和為" + total);



            try
            {
                //程式邏輯
                string str = Console.ReadLine();
                int.Parse(str);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine(e.Message + " 數字太大或太小");
            }
            catch (Exception ex)
            {
                //錯誤處理邏輯
                //Console.WriteLine("Error! Sorry!");

                //Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.GetType());
            }
            finally
            {
                Console.WriteLine("結束");
            }

        }

        private static int Add(int a, int b)
        {
            int all = 0;

            all = a - b;

            return all;
        }
    }
}

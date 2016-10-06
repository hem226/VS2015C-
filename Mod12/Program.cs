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
            SayHelloDelegate d = new SayHelloDelegate(SayHello);
            d.Invoke("tony");

        }

        delegate void SayHelloDelegate(string name);

        static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}

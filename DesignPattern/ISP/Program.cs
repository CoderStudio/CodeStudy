using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        /// <summary>
        ///Interface Segregation Principle 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            A a = new A();
            a.depend1(new B());
            a.depend2(new B());
            a.depend3(new B());

            C c = new C();
            c.depend1(new D());
            c.depend2(new D());
            c.depend3(new D());
            Console.ReadKey();
        }
    }
}

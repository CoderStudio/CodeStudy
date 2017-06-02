using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class D:I1,I3
    {
        public void method1()
        {
            Console.WriteLine("D implement I1 method1");
        }
        //public void method2() { }
        //public void method3() { }

        public void method4()
        {
            Console.WriteLine("D implement I3 method4");
        }
        public void method5()
        {
            Console.WriteLine("D implement I3 method5");
        }
    }
}

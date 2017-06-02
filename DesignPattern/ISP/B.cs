using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class B: I1,I2
    {
        public void method1()
        {
            Console.WriteLine("B implement I1 method1");
        }

        public void method2()
        {
            Console.WriteLine("B implement I2 method2");
        }
        public void method3()
        {
            Console.WriteLine("B implement I2 method3");
        }
        //public void method4()
        //{
         
        //}
        //public void method5()
        //{
         
        //}
    }
}

using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar myCar = Driver.DriverCar("BenzCar");
            myCar.run();
            Console.Read();
        }
    }
}

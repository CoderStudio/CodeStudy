using Factory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Service
{
    public class BenzCar : ICar
    {
        public void run()
        {
            Console.WriteLine("BenzCar run");
        }
    }
}

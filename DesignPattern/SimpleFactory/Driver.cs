using Factory.Interface;
using Factory.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Driver
    {
        public static ICar DriverCar(string carType)
        {
            switch (carType)
            {
                case "BMWCar": return new BMWCar();
                case "BenzCar": return new BenzCar();
                default: throw new Exception();
            }
        }
    }
}

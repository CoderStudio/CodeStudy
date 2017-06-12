using Factory.Interface;
using Factory.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class BenzDriver : Driver
    {
        public override ICar DriverCar()
        {
            return new BenzCar();
        }
    }

}

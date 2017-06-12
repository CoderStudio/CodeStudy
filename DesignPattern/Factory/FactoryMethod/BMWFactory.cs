using FactoryPattern.Interface;
using FactoryPattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.FactoryMethod
{
    public class BMWFactory: IFactory
    {
        public IRace CreateRace()
        {
            return new BMW();
        }

    }
}

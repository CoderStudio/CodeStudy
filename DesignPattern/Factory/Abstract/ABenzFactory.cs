using Factory.FactoryMethod;
using FactoryPattern.War3.Interface;
using FactoryPattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Abstract
{
    public   class ABenzFactory:AbstractFactory
    {
        public override IAuto CarAuto()
        {
            return new BenzAuto();
        }
        public override IRace CreateRace()
        {
            return new Benz();

        }

    }
}

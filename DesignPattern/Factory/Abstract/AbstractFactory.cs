using Factory.FactoryMethod;
using FactoryPattern.War3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Abstract 
{
    public abstract class AbstractFactory
    {
        public abstract IAuto CarAuto();
        public abstract IRace CreateRace();

    }
}

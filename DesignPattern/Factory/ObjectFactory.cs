using FactoryPattern.War3.Interface;
using FactoryPattern.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ObjectFactory
    {
        public static IRace CreateInstance(RaceType type)
        {
            IRace iRace = null;
            switch (type)
            {
                case RaceType.BMW:
                    iRace = new BMW();
                    break;
                case RaceType.Benz:
                    iRace = new Benz();

                    break;
                case RaceType.QQ:
                    iRace = new QQ();

                    break;
                case RaceType.Porsche:
                    iRace = new Porsche();

                    break;
                 
                default:
                    throw new Exception("wrong RaceType"); 
                   
            }
            return iRace;            
        }
    }

    public enum RaceType
    {
        BMW = 0,
        Benz = 1,
        QQ = 2,
        Porsche = 3,
        Five = 4
    }
}

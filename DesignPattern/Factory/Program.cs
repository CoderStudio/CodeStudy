using Factory.Abstract;
using Factory.FactoryMethod;
using FactoryPattern.War3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("*********************Factory*********************");
                {
                    IRace race = ObjectFactory.CreateInstance(RaceType.Benz);
                    race.ShowKing();
                };
                {
                    IRace race = ObjectFactory.CreateInstance(RaceType.BMW);
                    race.ShowKing();
                };
                {
                    IRace race = ObjectFactory.CreateInstance(RaceType.QQ);
                    race.ShowKing();
                };
                {
                    IRace race = ObjectFactory.CreateInstance(RaceType.Porsche);
                    race.ShowKing();
                };

                {
                    IFactory factory = new BenzFactory();
                    IRace race = factory.CreateRace();
                    race.ShowKing();

                }
                {
                    AbstractFactory factory = new ABenzFactory();
                    IRace race = factory.CreateRace();
                    race.ShowKing();
                    IAuto auto = factory.CarAuto();
                    auto.CarAuto();
                }
                Console.Read();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbFactory
{
    class Program
    {

        public interface IBusinessCar
        {
            void run();
        }

        public interface ISportCar
        {
            void run();
        }

        public class BMWBusinessCar : IBusinessCar
        {
            public void run()
            {
                Console.WriteLine("BMWCar run");
            }

        }

        public class BenzBusinessCar : IBusinessCar
        {
            public void run()
            {
                Console.WriteLine("BenzBusinessCar run");
            }
        }

        public class BMWSportCar : ISportCar
        {
            public void run()
            {
                Console.WriteLine("BMWSportCar run");
            }
        }

        public class BenzSportCar : ISportCar
        {
            public void run()
            {

                Console.WriteLine("BenzSportCar run");
            }
        }

        public interface IDriver
        {
            IBusinessCar BusinessCarDriver();
            ISportCar SportCarDriver();
        }

        public class BMWDriver : IDriver
        {
            public IBusinessCar BusinessCarDriver()
            {
                return new BMWBusinessCar();
            }
            public ISportCar SportCarDriver()
            {
                return new BMWSportCar();
            }
        }

        public class BenzDriver : IDriver
        {
            public IBusinessCar BusinessCarDriver()
            {
                return new BenzBusinessCar();
            }

            public ISportCar SportCarDriver()
            {
                return new BenzSportCar();
            }
        }


        public static void Main(string[] args)
        {
            IDriver myDriver = new BenzDriver();
            ISportCar myCar = myDriver.SportCarDriver();
            var mycar = myDriver.BusinessCarDriver();
            mycar.run();
            myCar.run();
            Console.Read();
        }
    }
}

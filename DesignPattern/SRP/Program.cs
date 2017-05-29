using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    class Program
    {
        /// <summary>
        /// single responsibility principle
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.breathe("Cow");
            animal.breathe("Sheep");
            animal.breathe("Pig");
            Console.ReadKey();
        }
    }
}

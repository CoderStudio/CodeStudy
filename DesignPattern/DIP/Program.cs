using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class Program
    {
        /// <summary>
        /// Dependence Inversion Principle 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Mother mother = new Mother();
            mother.narrate(new Book());
            mother.narrate(new Newspaper());

            Console.ReadKey();
        }
    }
}

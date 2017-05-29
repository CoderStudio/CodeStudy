using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Minus a = new Minus();
            Console.WriteLine("100-50=" + a.func1(100, 50));
            Console.WriteLine("100-80=" + a.func1(100, 80));

            Console.ReadKey();
        }
    }
}

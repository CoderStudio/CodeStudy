using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKP
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyManager e = new CompanyManager();
            e.printAllEmployee(new SubCompanyManager());
            Console.ReadKey();
        }
    }
}

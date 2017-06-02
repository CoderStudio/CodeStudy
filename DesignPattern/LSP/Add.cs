using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Add :Minus
    {
        public int Bfunc1(int a, int b)
        {
            return a + b;
        }

        public int Bfunc2(int a, int b)
        {
            return Bfunc1(a,b) +100;
        }
    }
}

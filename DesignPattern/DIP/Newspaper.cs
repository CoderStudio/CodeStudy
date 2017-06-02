using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Newspaper :IReader
    {
        public string GetContent()
        {
            return "Newspaper content...";
        }
    }
}

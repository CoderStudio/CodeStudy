using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class Book :IReader
    {
        public string GetContent()
        {
            return "This is story book……";
        }
    }
    class Mother
    {
        public void narrate(IReader reader)
        {
            Console.WriteLine("Mom tell story");
            Console.WriteLine(reader.GetContent());
        }
    }

}

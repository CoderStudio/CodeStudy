using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Singleton
{
    public class Singleton
    {
        private Singleton()
        {
            long lResult = 0;
            for (int i = 0; i < 10000000; i++)
            {
                lResult += i;
            }

            Thread.Sleep(1000);
            Console.WriteLine("{0} has been created",this.GetType().Name);
        }

        private static Singleton _singleton = null;

        private static object locker = new object();
        private static object locker2 = new object();

        public static Singleton CreateInstance()
        {
            if (_singleton ==null)
            {
                lock (locker)
                {
                    Console.WriteLine("********enter lock");
                    if (_singleton == null)
                    {
                        _singleton = new Singleton();
                    }
                }
            }
                        
            return _singleton;
        }
        public void Write()
        {
            lock (locker2)
            {
                this._i++;
            }
            //Console.WriteLine("This is write operation.");
        }
        private int _i = 0;

        public void Show()
        {
            Console.WriteLine(this._i);
        }
    }
}

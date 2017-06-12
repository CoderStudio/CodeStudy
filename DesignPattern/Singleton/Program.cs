using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is singleton 1.0");
                var taskFactory = new TaskFactory();
                List<Task> tasklist = new List<Task>();

                //for (int i = 0; i < 5; i++)
                //{
                //    tasklist.Add(taskFactory.StartNew(() => {
                //        Singleton singleton = Singleton.CreateInstance();
                //        singleton.Write();
                //    }));                   
                //}
                //Task.WaitAll(tasklist.ToArray());
                //Console.WriteLine("**************************************");
                //for (int i = 0; i < 5; i++)
                //{
                //    taskFactory.StartNew(() =>
                //    {
                //        Singleton singleton = Singleton.CreateInstance();
                //        singleton.Write();
                //    });
                //}

                { Singleton singleton = Singleton.CreateInstance(); }

                {
                    for (int i = 0; i < 10000; i++)
                    {
                        tasklist.Add(taskFactory.StartNew(() => {
                            Singleton singleton = Singleton.CreateInstance();
                            singleton.Write();
                        }));
                    }
                    Task.WaitAll(tasklist.ToArray());
                }
                {
                     Singleton singleton = Singleton.CreateInstance();
                    singleton.Show();

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.Read();            
        }
    }
}

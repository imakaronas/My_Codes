using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JM_ConsoleApp_UsingThreads_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread tid1 = new Thread(new ThreadStart(Thread1));
            Thread tid2 = new Thread(new ThreadStart(Thread2));

            tid1.Start();
            tid2.Start();

            Console.WriteLine("Done");

            Console.ReadLine();

        }

        public static void Thread1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format("Thread1 {0}", i));
                Thread.Yield();
            }
        }

        public static void Thread2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(string.Format("Thread2 {0}", i));
                Thread.Yield();
            }
        }

    }
}

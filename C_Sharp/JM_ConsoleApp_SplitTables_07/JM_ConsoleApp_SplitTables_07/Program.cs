using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_07
{
    class Program
    {
        static void Main(string[] args)
        {


            //================================================
            //How to sort a String Array

            string[] MyArrStr = new string[] { "c", "a", "d", "b" };
            Array.Sort(MyArrStr);
            foreach (var str in MyArrStr)
            {
                Console.Write(str);
            }

            Console.ReadLine();

        }
    }
}

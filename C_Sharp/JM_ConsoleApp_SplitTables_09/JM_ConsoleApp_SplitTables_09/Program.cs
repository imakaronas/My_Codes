using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //================================================

            //
            string[] myarray4 = new string[] { "c", "b", "d", "a" };
            Array.Sort(myarray4);
            Array.Reverse(myarray4);
            foreach (var str in myarray4)
            {
                Console.WriteLine(str.ToString());
            }


            Console.ReadLine();

        }
    }
}

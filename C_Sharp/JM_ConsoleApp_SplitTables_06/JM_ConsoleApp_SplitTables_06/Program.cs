using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_06
{
    class Program
    {
        static void Main(string[] args)
        {

            //================================================
            //How to sort an Integer Array


            int[] myarray2 = new int[] { 3, 1, 4, 5, 2 };
            Array.Sort(myarray2);
            foreach (var str in myarray2)
            {
                Console.Write(str.ToString());
            }


            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_08
{
    class Program
    {
        static void Main(string[] args)
        {


           
            //================================================
            //Sort an Integer array in descending order
            int[] myarray3 = new int[] { 3, 1, 4, 5, 2 };
            Array.Sort(myarray3);
            Array.Reverse(myarray3);
            foreach (var str in myarray3)
            {
                Console.WriteLine(str.ToString());
            }

            Console.ReadLine();

        }
    }
}

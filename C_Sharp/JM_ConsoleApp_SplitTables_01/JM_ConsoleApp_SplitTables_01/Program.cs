using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myarray = new string[10];

            myarray[0] = "John";
            myarray[1] = "Maria";
            myarray[2] = "Foteini";
            myarray[3] = "Anthi";


            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(myarray[i]);
            }

            Console.ReadLine();

            //====================================================
        }
    }
}

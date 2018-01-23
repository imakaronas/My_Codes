using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //How to resize an Array
            char[] array = new char[5]; array[0] = 'A'; array[1] = 'B'; array[2] = 'C'; array[3] = 'D'; array[4] = 'E';

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }

            Array.Resize(ref array, 3);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToString());
            }


            Console.ReadLine();
            //================================================

        }
    }
}

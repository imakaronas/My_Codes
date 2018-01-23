using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_Arrays_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray1 = new int[10];

            for (int cnt = 0; cnt < 10; cnt++)
            {
                myArray1[cnt] = cnt;
            }

            for (int i = 0; i < myArray1.Length; i++)
            {
                Console.WriteLine(myArray1[i].ToString());

            }

            Console.ReadLine();

        }
    }
}

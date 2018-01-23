using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_Arrays_03
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            //You can use Enumerable.Range to create a range of numbers:
            int[] arr = Enumerable.Range(1, 100).ToArray();

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(arr[i]);

            }
            Console.ReadLine();

        }
    }
}

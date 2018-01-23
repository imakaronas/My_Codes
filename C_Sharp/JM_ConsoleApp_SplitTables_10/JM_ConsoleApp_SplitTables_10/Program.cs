using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_10
{
    class Program
    {
        static void Main(string[] args)
        {

            //================================================
            // LINQ OrderByDescending
            //You can use LINQ OrderByDescending method to reverse an array. OrderByDescending method sorts elements from high to low.
            //The following C# source code shows how to sort an array in descending order by using LINQ OrderByDescending.

            string[] myarray5 = new string[] { "a", "b", "c", "d" };
            myarray5 = myarray5.OrderByDescending(c => c).ToArray();
            foreach (var str in myarray5)
            {
                Console.WriteLine(str.ToString());
            }


            Console.ReadLine();

        }
    }
}

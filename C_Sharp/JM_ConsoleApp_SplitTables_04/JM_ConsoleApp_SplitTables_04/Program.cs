using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //================================================
            //Converting String array to List

            string[] week = new string[7];
            week[0] = "Sunday";
            week[1] = "Monday";
            week[2] = "Tuesday";
            week[3] = "Wednsday";
            week[4] = "Thursday";
            week[5] = "friday";
            week[6] = "Saturday";

            List<string> lst = new List<string>(week);

            foreach (string day in lst)
            {
                Console.WriteLine(day);
            }




            Console.ReadLine();

        }
    }
}

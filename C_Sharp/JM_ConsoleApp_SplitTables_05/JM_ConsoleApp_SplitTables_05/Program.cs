using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //================================================
            //How can I test if an array contains a certain value?

            string[] week2 = new string[7];
            week2[0] = "Sunday";
            week2[1] = "Monday";
            week2[2] = "Tuesday";
            week2[3] = "Wednsday";
            week2[4] = "Thursday";
            week2[5] = "friday";
            week2[6] = "Saturday";

            string value = "Wednsday";

            int pos = Array.IndexOf(week2, value);

            if (pos > -1)
                Console.WriteLine(value + " exist !");
            else
                Console.WriteLine(value + " not exist !");


            Console.ReadLine();

        }
    }
}

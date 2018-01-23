using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_UsingDates_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //***********************************************************************//
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.DayOfWeek);

            Console.WriteLine("**********");

            int dtYear = DateTime.Now.Year;
            int dtMonth = DateTime.Now.Month;
            int dtDay = DateTime.Now.Day;

            Console.WriteLine("Year : {0}", dtYear);
            Console.WriteLine("Month : {0}", dtMonth);
            Console.WriteLine("Day : {0}", dtDay);

            Console.WriteLine();
            Console.ReadLine();

            DateTime dtChrDate = new DateTime(2018, 12, 25);
            Console.WriteLine("Christmas Date : {0}", dtChrDate);
            Console.WriteLine("Days for Christmas XXX: {0}", dtChrDate.Day - dt.Day);

            Console.WriteLine(dtChrDate);
            Console.ReadLine();

            //***********************************************************************//

            // get Lat Day Of Current Month

            DateTime newDate = new DateTime();
            var LastDay2 = newDate.AddMonths(1);
            var LastDay3 = LastDay2.Day * (-1);
            var d5 = LastDay2.AddDays(LastDay3);

            Console.WriteLine(d5);

            Console.ReadLine();


        }
    }
}

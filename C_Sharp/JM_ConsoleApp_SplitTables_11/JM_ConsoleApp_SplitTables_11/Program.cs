using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_SplitTables_11
{
    class Program
    {
        static void Main(string[] args)
        {


            //================================================
            //How to Create an Array with different data types

            object[] mixedArray = new object[4];
            mixedArray[0] = 10;
            mixedArray[1] = "Jack";
            mixedArray[2] = true;
            mixedArray[3] = System.DateTime.Now;

            //In order to retrieve different data types from an Object array, you can convert an element to the appropriate data type
            int id = int.Parse(mixedArray[0].ToString());
            DateTime admissionDate = DateTime.Parse(mixedArray[3].ToString());


            Console.WriteLine(admissionDate);


            Console.ReadLine();

        }
    }
}

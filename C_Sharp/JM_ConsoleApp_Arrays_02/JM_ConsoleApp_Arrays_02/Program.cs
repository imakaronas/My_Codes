using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_Arrays_02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("CanArrayBeSplit ;");

            Console.WriteLine("Testing: " + CanArrayBeSplit(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }));
            Console.WriteLine("Testing: " + CanArrayBeSplit(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 45 }));

            Console.ReadLine();

        }

        public static bool CanArrayBeSplit(int[] intArray)
        {
            int sum = 0;
            foreach (int v in intArray)
            {
                sum += v;
            }

            int left = 0;
            int right = sum;

            for (int i = 0; left != right && i < intArray.Length; i++)
            {
                left += intArray[i];
                right -= intArray[i];
            }

            return left == right;
        }
    }
}

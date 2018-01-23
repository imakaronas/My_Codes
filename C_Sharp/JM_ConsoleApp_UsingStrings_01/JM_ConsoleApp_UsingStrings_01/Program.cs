using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_UsingStrings_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Left Padding a code if the lenght is less than 25 chars
            string strAccountCode = String.Empty;
            strAccountCode = "123456789";

            string strNewPaymentCode = String.Empty;

            if (strAccountCode.Length < 25)
            {
                strNewPaymentCode = strAccountCode.PadLeft(25, '0');
            }
            else
            {
                strNewPaymentCode = strAccountCode;
            }
            
            Console.WriteLine("====== Left padding a code if the lenght is less than 25 chars ====== \n");
            Console.WriteLine("Old Code: " + strAccountCode);
            Console.WriteLine("New Code: " + strNewPaymentCode);
            Console.WriteLine("\n");
            Console.WriteLine("=====================================================================");
            Console.ReadLine();
            Console.WriteLine("\n");


            // Hide chars except 1 char in words of a sentence
            Console.WriteLine("====== Hide chars except 1 char in words of a sentence \n");

            string accountname = string.Empty;
            accountname = "SSK PROJECT For nbg!";
            //accountname = "S** P****** F** n***";

            string nameaccountdescription = string.Empty;
            string nameaccountdescription2 = string.Empty;

            string[] words = accountname.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                Console.WriteLine(word);
                //nameaccountdescription += string.Format("{0}", word.Substring(0, 1) + "***** ");
                nameaccountdescription += string.Format("{0}", word.Substring(0, 1) + "* ");
                Console.WriteLine("nameaccountdescription :" + nameaccountdescription);

                Console.WriteLine("----------------");

                int intlenghtofword = 0;
                intlenghtofword = word.Length - 1;
                string newstring = word.Remove(1, intlenghtofword);
                var newstring2 = new String('*', word.Length - 1);

                nameaccountdescription2 += string.Format("{0}", newstring + newstring2 + " ");
                Console.WriteLine("nameaccountdescription2 : " + nameaccountdescription2);


                Console.WriteLine("=====================");
            }


            Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine("=====================================================================");
            Console.ReadLine();
            Console.WriteLine("\n");

            // Using Reg Express
            Console.Write(System.Text.RegularExpressions.Regex.Replace("test", ".", "*"));

            Console.ReadLine();


        }
    }
}

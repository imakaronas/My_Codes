using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM_ConsoleApp_FizzBuzz_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            // FizzBuzz is a quite popular childrens game. Counting from 1 to 100, and every time a number is divisible 
            //by 3 calling "Fizz", every time a number is divisible by 5 calling "Buzz" and every time a number is divisible 
            //by 3 and 5, calling "FizzBuzz instead of the number

            // -- 1st --
            Console.WriteLine("--1st --");
            for (int i = 1; i <= 20; i++)
            {

                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }

            Console.ReadLine();

            // -- 2nd --
            Console.WriteLine("-- 2nd --");

            for (int i = 1; i <= 20; i++)
            {
                var mymessag = ((i % 3 == 0) && (i % 5 == 0) ? "FizzBuzz" : (i % 3 == 0) && (i % 5 != 0) ? "Fizz" : (i % 3 != 0) && (i % 5 == 0) ? "Buzz" : i.ToString());
                Console.WriteLine(mymessag);
            }

            Console.ReadLine();

            // -- 3rd --
            Console.WriteLine("-- 3rd --");
            for (int i = 1; i <= 20; i++)
            {
                StringBuilder mystringmessage = new StringBuilder();
                mystringmessage.Clear();

                if (i % 3 == 0)
                {
                    mystringmessage.Append("Fizz");
                }

                if (i % 5 == 0)
                {
                    mystringmessage.Append("Buzz");
                }

                if (mystringmessage.Length == 0)
                {
                    mystringmessage.Append(i.ToString());
                }

                Console.WriteLine(mystringmessage);

            }

            Console.ReadLine();


            // -- 4th --
            Console.WriteLine("-- 4th --");

            for (int i = 1; i <= 20; i++)
            {
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }

            Console.ReadLine();



            // -- 5th --
            Console.WriteLine("-- 5th --");

            for (int i = 1; i < 21; i++) Console.WriteLine("{0:#;}{1:;;Fizz}{2:;;Buzz}", i % 3 * i % 5 == 0 ? 0 : i, i % 3, i % 5);

            Console.ReadLine();



            // -- 6th --
            Console.WriteLine("-- 6th --");



            Console.ReadLine();




            // -- 7th --
            Console.WriteLine("-- 7th --");

            for (int n = 1; n <= 20; n++)
            {
                if (n % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(n);
                }
            }

            Console.ReadLine();



            // -- 8th --
            Console.WriteLine("-- 8th --");

            var list = Enumerable.Range(1, 20)
                .Select(n => {
                    if (n % 15 == 0)
                    {
                        return "FizzBuzz";
                    }
                    if (n % 3 == 0)
                    {
                        return "Fizz";
                    }
                    if (n % 5 == 0)
                    {
                        return "Buzz";
                    }
                    return n.ToString();
                });

            foreach (string item in list)
                Console.WriteLine(item);

            Console.ReadLine();



            // -- 9th --
            //the crazy one line version:
            Console.WriteLine("-- 9th --");

            Console.WriteLine(
                String.Join(
                    Environment.NewLine,
                    Enumerable.Range(1, 20)
                        .Select(n => n % 15 == 0 ? "FizzBuzz"
                            : n % 3 == 0 ? "Fizz"
                                : n % 5 == 0 ? "Buzz"
                                    : n.ToString())
                ));

            Console.ReadLine();


            // -- 10th --
            Console.WriteLine("-- 10th --");

            const string FIZZ = "Fizz";
            const string BUZZ = "Buzz";
            const string FIZZBUZZ = "FizzBuzz";

            int k = 0;
            while (k < 20)
            {
                Console.WriteLine(++k);
                Console.WriteLine(++k);
                Console.WriteLine(FIZZ); ++k;
                Console.WriteLine(++k);
                Console.WriteLine(BUZZ); ++k;
                Console.WriteLine(FIZZ); ++k;
                Console.WriteLine(++k);
                Console.WriteLine(++k);
                Console.WriteLine(FIZZ); ++k;
                Console.WriteLine(BUZZ); ++k;
                Console.WriteLine(++k);
                Console.WriteLine(FIZZ); ++k;
                Console.WriteLine(++k);
                Console.WriteLine(++k);
                Console.WriteLine(FIZZBUZZ); ++k;
            }

            Console.ReadLine();


            // -- 11th --
            Console.WriteLine("-- 11th --");

            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                    Console.Write("Fizz");
                if (i % 5 == 0)
                    Console.Write("Buzz");
                if (!(i % 3 == 0 || i % 5 == 0))
                    Console.Write(i);

                Console.Write(Environment.NewLine);
            }

            Console.ReadLine();




            // -- 12th --
            Console.WriteLine("-- 12th --");

            Enumerable.Range(1, 100).Select(x =>
                    (x % 15 == 0) ? "FIZZBUZZ"
                        : (x % 5 == 0) ? "BUZZ"
                            : (x % 3 == 0) ? "FIZZ"
                                : x.ToString()
                )
                .ToList()
                .ForEach(Console.WriteLine);

            Console.ReadLine();




            // -- 13th --
            Console.WriteLine("-- 13th --");

            for (int j = 1; j <= 100; j++)
            {
                string Output = "";

                if (j % 3 == 0) Output = "Fizz";// Divisible by 3 --> Fizz

                if (j % 5 == 0) Output += "Buzz"; // Divisible by 5 --> Buzz

                if (Output == "") Output = j.ToString(); // If none then --> number

                Console.WriteLine(Output); // Finally print the complete output
            }

            Console.ReadLine();

        }
    }
}

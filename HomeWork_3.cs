using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Diagnostics.Tracing;

namespace _20230127_HomeWork_3
{
    public class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            // 1. Read some string str. Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text.

            string someString = "Read some string str. Calculate the counts of characters ‘a’, ’o’, ’i’, ’e’  in this text. " +
                 "2. Ask user to enter the number of month. Read value and output the count of days in this month. " +
                "3. Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.";

            char aChar = 'a';
            char oChar = 'o';
            char iChar = 'i';
            char eChar = 'e';
            
            int aCount = someString.Split(aChar).Length - 1;
            int oCount = someString.Split(oChar).Length - 1;
            int iCount = someString.Split(iChar).Length - 1;
            int eCount = someString.Split(eChar).Length - 1;

            Console.WriteLine("Text: '{0}'", someString);
            Console.WriteLine("\nCounts of characters ‘a’ = {0}, ‘o’ = {1}, ‘i’ = {2}, ‘e’ = {3}", aCount, oCount, iCount, eCount);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 2. Ask user to enter the number of month. Read value and output the count of days in this month.

            bool ok = false;
            string result = string.Empty;
            int monthNumber;
            const int MONTH_POSSIBLE = 12;
            // int yearNumber;
            // const int YEAR_POSSIBLE = 2100;

            int[] yearPossible = new int[1];

            for (int i = 0; i < yearPossible.Length; i++)
            {
                yearPossible[i] = rnd.Next(1900, 2101);
            }

            /*do
            {
                Console.Write("Enter year: ");
                result = Console.ReadLine();
                ok = int.TryParse(result, out yearNumber);
                ok = yearNumber > 0 && yearNumber <= YEAR_POSSIBLE;
                Console.Clear();
            }
            while (!ok);*/

            do
            {
                Console.Write("Enter number of month: ");
                result = Console.ReadLine();
                ok = int.TryParse(result, out monthNumber);
                ok = monthNumber > 0 && monthNumber <= MONTH_POSSIBLE;
                Console.Clear();
            }
            while (!ok);

            int days = DateTime.DaysInMonth(yearPossible[0], monthNumber);

            Console.WriteLine("Random year: {0}, month: {1}, days: {2}", yearPossible[0], monthNumber, days);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 3. Enter 10 integer numbers. Calculate the sum of first 5 elements if they are positive or product of last 5 element in  the other case.

            int[] source = new int[10];

            for (int i = 0; i < source.Length; i++)
            {
                source[i] = rnd.Next(-1000, 1001);
            }

            Console.Write("Source: ");
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write("{0}, ", source[i]);
            }

            Console.Write("\n\nFirst 5 positive number:");

            int positiveNumber = 0;

            for (int a = 0; a < 5; a++)
            {
                if (source[a] < 0) continue;
                Console.Write(" {0} +", source[a]);
                positiveNumber = positiveNumber + source[a];
            }

            Console.Write("= {0}", positiveNumber);
            Console.Write("\n\nLast 5 number:");

            int lastNumber = 0;

            for (int a = 5; a < 10; a++)
            {
                Console.Write("{0}, ", source[a]);
                lastNumber = lastNumber + source[a];
            }

            Console.Write("= {0}", lastNumber);
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

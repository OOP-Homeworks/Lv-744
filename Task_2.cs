using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Program
    {
        public struct RGB
        {
            public byte red;
            public byte green;
            public byte blue;
        }

        public enum TestCaseStatus
        {
            Pass,
            Fail,
            Blocked,
            WP,
            Unexecuted
        }

        #region Constants

        const int MAX_DAYS_COUNT = 31;
        const int MAX_MONTH_COUNT = 12;
        const int DAY_TIME_00 = 00;
        const int DAY_TIME_12 = 12;
        const int DAY_TIME_16 = 16;
        const int DAY_TIME_24 = 24;

        #endregion

        static void Main(string[] args)
        {
            // 1. Enter two integers numbers and check if they can represent the day and month. Output result on the console.

            string result = string.Empty;
            bool ok = false;
            int dayNumber = 0;

            while (!ok)
            {
                Console.Write("Enter number day:  ");
                result = Console.ReadLine();
                ok = int.TryParse(result, out dayNumber);
                Console.Clear();
            }

            int monthNumber = 1;
            ok = false;

            while (!ok)
            {
                Console.Write("Enter number month: ");
                result = Console.ReadLine();
                ok = int.TryParse(result, out monthNumber);
                Console.Clear();
            }

            bool dayPossibly = dayNumber >= 1 && dayNumber <= MAX_DAYS_COUNT;
            bool monthPossibly = monthNumber >= 1 && monthNumber <= MAX_MONTH_COUNT;

            Console.WriteLine("Number day: {0} = {1}, number month: {2} = {3}", dayNumber, dayPossibly, monthNumber, monthPossibly);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 2. Enter double  number  and get the first 2 digits after the point of this number and output the sum of these numbers. For example: 3.456 -> 4+5=9

            double number = 3.456;
            Console.WriteLine("Enter number: {0}.", number);

            int number2 = (int)number;
            number -= number2;
            number *= 10;
            number2 = (int)number;
            number -= number2;
            number *= 10;
            number2 += (int)number;

            Console.WriteLine("Result: {0}", number2);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 3. Enter integer number  h, representing the time of day (hour). Depending on the time of day, output greetings("Good morning!", "Good afternoon!", "Good evening!“ or "Good night!")

            DateTime localDate = DateTime.Now;
            int hour = localDate.Hour;
            string greetings;

            if (hour >= DAY_TIME_00 && hour < DAY_TIME_12)
            {
                greetings = "Good morning!";
            }
            else if (hour >= DAY_TIME_12 && hour < DAY_TIME_16)
            {
                greetings = "Good afternoon!";
            }
            else if (hour >= DAY_TIME_16 && hour < DAY_TIME_24)
            {
                greetings = "Good evening!";
            }
            else
            {
                greetings = "Good night!";
            }

            Console.WriteLine("If the time is {0}, you say {1}", hour, greetings);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 4. Identify enum TestCaseStatus {Pass, Fail, Blocked, WP, Unexecuted}. Assign status “Pass” for variable test1Status and output result on the console.

            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine($"Integral value of {test1Status} is {(int)test1Status}");

            var test2Status = (TestCaseStatus)1;
            Console.WriteLine(test2Status);

            var test3Status = (TestCaseStatus)4;
            Console.WriteLine(test3Status);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 5. Determine struct RGB that represents the color with fields red, green, blue (type byte). Identify two variables of this type and enter their fields for white and black colors.

            RGB white;
            white.red = 0;
            white.green = 0;
            white.blue = 0;

            RGB black;
            black.red = 255;
            black.green = 255;
            black.blue = 255;

            Console.WriteLine("White code: [r: {0}, g: {1}, b: {2}]", white.red, white.green, white.blue);
            Console.WriteLine("Black code: [r: {0}, g: {1}, b: {2}]", black.red, black.green, black.blue);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

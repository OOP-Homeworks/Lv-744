using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Task_3
{
    struct Drink
    {
        public string name;
        public double prise;

        public void info()
        {
            System.Console.WriteLine("{0} = ${1}", name, prise);
        }
    }

    public class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {

            // 1. Enter two integer numbers a and b. Calculate how many integers in the range [a..b] are divided by 3 without remainder. //1..10 -> 3

            int possible = 0;

            int[] source = new int[2];

            for (int i = 0; i < source.Length; i++)
            {
                source[i] = rnd.Next(0, 1001);
            }

            if (source[0] > source[1])
            {
                for (int a = source[1]; a < source[0]; a++)
                {
                    if (a % 3 == 0) possible++;
                }
            }
            else
            {
                for (int a = source[0]; a < source[1]; a++)
                {
                    if (a % 3 == 0) possible++;
                }
            }

            Console.WriteLine("If: a = {0}, b = {1}", source[0], source[1]);
            Console.WriteLine("\nDivided by 3 without remainder: {0}", possible);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 2. Enter some string text from the console.Print each second character.

            string taskTwo = "Enter some string text from the console. Print each second character.";
            string taskReplace = taskTwo.Replace(".", "");
            taskReplace = taskReplace.Replace(" ", "");
            char[] chars = taskReplace.ToCharArray();

            Console.WriteLine("\nOriginal text: {0}", taskTwo);
            Console.WriteLine("\nTruncated text: {0}\n", taskReplace);
            Console.Write("Each second character: ");
            
            for (int ctr = 1; ctr < chars.Length; ctr += 2)
            {
                Console.Write("{0},", chars[ctr]);
            }
            
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 3. Enter the name of the drink(coffee, tea, juice, water). Print the name and price of the drink.

            Drink coffee;
            coffee.name = "Coffee";
            coffee.prise = 5.00;

            Drink tea;
            tea.name = "Tea";
            tea.prise = 2.10;

            Drink juice;
            juice.name = "Juice";
            juice.prise = 4.05;

            Drink water;
            water.name = "Water";
            water.prise = 1.00;

            Console.Write("Enter name drink (coffee, tea, juice, water): ");
            string drinkName = Console.ReadLine();

            if ("coffee" == drinkName.ToLower() || "c" == drinkName.ToLower())
            {
                coffee.info();
            }

            if ("tea" == drinkName.ToLower() || "t" == drinkName.ToLower())
            {
                tea.info();
            }

            if ("juice" == drinkName.ToLower() || "j" == drinkName.ToLower())
            {
                juice.info();
            }

            if ("water" == drinkName.ToLower() || "w" == drinkName.ToLower())
            {
                water.info();
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 4. Enter a sequence of positive integers(to the first negative). Calculate the arithmetic average of the entered positive numbers. //1,6,3,9,-8 -> (1+6+3+9)/4

            const int SEQUENCE_NEEDED = 11;

            int[] sequence = new int[SEQUENCE_NEEDED];

            for (int i = 0; i < sequence.Length; i++)
            {
                sequence[i] = rnd.Next(-1000, 10001);
            }

            Console.WriteLine("Source:");
            for (int i = 0; i < sequence.Length; i++)
            {
                Console.Write("{0} ", sequence[i]);
            }

            int positiveNumber = 0;

            Console.WriteLine("\nPositive number:");

            for (int a = 0; a < SEQUENCE_NEEDED; a++)
            {
                if (sequence[a] < 0) break;
                Console.Write(" {0} +", sequence[a]);
                positiveNumber = positiveNumber + sequence[a];
            }

            Console.Write("= {0} / 4 = {1}", positiveNumber, positiveNumber / 4);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 5. Check if the entered year is a leap.

            int[] randomYear = new int[1];

            for (int i = 0; i < randomYear.Length; i++)
            {
                randomYear[i] = rnd.Next(1800, 2100);
            }

            if (randomYear[0] % 4 == 0)
            {
                if (randomYear[0] % 100 != 0 || (randomYear[0] % 100 == 0 && randomYear[0] % 400 == 0))
                {
                    Console.WriteLine(" {0} is a leap year", randomYear[0]);
                }
                else
                {
                    Console.WriteLine(" {0} is not a leap year", randomYear[0]);
                }
            }
            else
            {
                Console.WriteLine(" {0} is not a leap year", randomYear[0]);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 6. Find the sum of digits of the entered integer number //(365 -> 3+6+5)

            int[] randomNumber = new int[1];

            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = rnd.Next(100, 999);
            }

            double number = randomNumber[0] / 100;
            Console.WriteLine("Random number: {0}", randomNumber[0]);

            int number2 = (int)number * 100;
            int number3 = randomNumber[0] - number2;
            number2 = number3 / 10;
            int number4 = number2 * 10;
            number3 -= number4;
            number4 = (int)number + number2 + number3;

            Console.WriteLine("\nResult: {0} + {1} + {2} = {3}", number, number2, number3, number4);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 7. Check if the entered integer number contains only odd digits.

            if ((int)number % 2 == 0 || number2 % 2 == 0 || number3 % 2 == 0)
            {
                Console.WriteLine("{0} number not a contains only odd digits", randomNumber[0]);
            }
            else
            {
                Console.WriteLine("{0} number contains only odd digits", randomNumber[0]);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

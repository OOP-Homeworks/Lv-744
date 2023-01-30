using System;
using System.Linq;

namespace Task_3_2023
{
    class Program
    {


        enum Drinks
        {
            coffee,
            juice,
            tea,
            water
        }

        static int Sum(int myValue)
        {
            if (myValue < 10)
                return myValue;
            int digit = myValue % 10;
            int nextDigit = myValue / 10;
            return digit + Sum(nextDigit);
        }
        static void  IsOddDigits(int consoleInput)
        {
            bool isOdd;

            do
            {

                int digit = consoleInput % 10;
                if (digit % 2 == 1)
                {
                    isOdd = true;
                    Console.WriteLine("{0} is odd {1}", digit, isOdd);
                }
                else
                {
                    isOdd = false;
                    Console.WriteLine("{0} is odd {1}", digit, isOdd);
                }
                consoleInput /= 10;

            } while (consoleInput >= 1);
            
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            Task7_1();
            
            



            static void Task1()
            {

                int counter = 0, number = 0;
                int input1 = 0, input2 = 0;
                Console.WriteLine("Enter two integer numbers : ");
                try
                {
                    input1 = Convert.ToInt32(Console.ReadLine());
                    input2 = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Format exeption, try again..");
                }
                for (int i = input1; i < input2; i++)
                {
                    number = i % 3;
                    if (number == 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine("Division without residue = " + counter);
            }

            static void Task2()
            {

                Console.Write("\nEnter some text to console : ");
                string input = Console.ReadLine();
                char[] array = input.ToCharArray();

                for (int i = 1; i < input.Length; i++, i++)
                    Console.Write("  {0}", array[i]);
            }

            static void Task3()
            {

                Console.WriteLine("\nWhat do you want to drink ? ");
                string str = Console.ReadLine();

                switch (str)
                {
                    case "coffee":
                        Console.WriteLine(Drinks.coffee + " cost 2$");
                        break;
                    case "juice":
                        Console.WriteLine(Drinks.juice + " cost 1.5$");
                        break;
                    case "tea":
                        Console.WriteLine(Drinks.tea + " cost 1$");
                        break;
                    case "water":
                        Console.WriteLine(Drinks.water + " cost 0.5$");
                        break;
                    default:
                        Console.WriteLine("We dont have this drink(");
                        break;

                }
            }

            static void Task4()
            {

                int inp = 0, summa = 0, count = 0;
                double avarage;
                Console.WriteLine("\nEnter integer numbers : ");
                for (; ; )
                {
                    inp = Convert.ToInt32(Console.ReadLine());
                    if (inp >= 0)
                    {
                        summa += inp;
                        count++;
                    }
                    else
                    {
                        avarage = (double)summa / count;
                        Console.WriteLine("You enter negative integer. Avarage of positive integers = {0}", avarage);
                        break;
                    }
                }
            }

            static void Task5()
            {

                int year = 0;
                Console.WriteLine("\nEnter year : ");
                try
                {
                    year = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Format exeption. ");
                }
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
                else
                {
                    Console.WriteLine("{0} is NOT a leap year.", year);
                }
            }

            static void Task6()
            {

                Console.WriteLine("Enter your number : ");
                int myValue = int.Parse(Console.ReadLine());
                int res = Sum(myValue);
                
                Console.WriteLine("Result = {0}", res);
            }
            static void Task7_1()
            {
                int consoleInput = Convert.ToInt32(Console.ReadLine());
                IsOddDigits(consoleInput);
            }

            static void Task7()
            {
                Console.WriteLine("Enter integer number : ");
                int myString = int.Parse(Console.ReadLine());
                bool isOdd;

                do
                {

                    int digit = myString % 10;
                    if (digit % 2 == 1)
                    {
                        isOdd = true;
                        Console.WriteLine("{0} is odd {1}", digit, isOdd);
                    }
                    else
                    {
                        isOdd = false;
                        Console.WriteLine("{0} is odd {1}", digit, isOdd);
                    }
                    myString /= 10;

                } while (myString >= 1);
            }
        }






    }



}

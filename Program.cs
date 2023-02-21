using System.Collections.Concurrent;
using System.Globalization;
using System.Security.Cryptography;

namespace Lecture6_744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task #1&2");
            TaskHomework_1_2();

            Console.WriteLine("Task #3");
            TaskHomework_3();

            Console.ReadKey();

        }

        static void TaskHomework_1_2()
        {
            int i = 0;

            while (i<=5)
            {
                try
                {
                    Console.Write("Enter int a = ");
                    string a_sting = Console.ReadLine().Replace(',', '.');
                    Console.Write("Enter int b = ");
                    string b_sting = Console.ReadLine().Replace(',', '.');

                    NumberFormatInfo provider = new NumberFormatInfo();
                    provider.NumberDecimalSeparator = ".";
                    provider.NumberGroupSeparator = ",";

                    double a_double = Convert.ToDouble(a_sting, provider);
                    double b_double = Convert.ToDouble(b_sting, provider);

                    if (a_double.ToString().Contains(',')==true && b_double.ToString().Contains(',') == true)
                    {
                        throw new Exception("You enter double!");
                    }

                    int a = Int32.Parse(a_sting);
                    int b = Int32.Parse(b_sting);
                    int result = Div(a, b);
                    Console.WriteLine($"{a} / {b} = {result}");
                }
                catch (DivideByZeroException exeption)
                {
                    Console.WriteLine("Div by 0 = " + exeption.Message);
                }
                catch (ArithmeticException exeption)
                {
                    Console.WriteLine("Another exeption = " + exeption.Message);
                }
                catch (FormatException exeption)
                {
                    Console.WriteLine("Format exeption = " + exeption.Message);
                }
                catch (Exception exeption)
                {
                    Console.WriteLine("Total exeption = " + exeption.Message);
                }
                finally
                {
                    Console.WriteLine($"Finally msg");
                }

                i++;

            }

        }

        static void TaskHomework_3()
        {
            int min = 0;
            int max = 0;

            bool allIsOk = true;

            try
            {
                Console.Write("Enter int Min = ");
                min = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter int Max = ");
                max = Convert.ToInt32(Console.ReadLine());

                if (min > max)
                {
                    throw new Exception("Error! Min > Max!");
                }

            }
            catch (FormatException exeption)
            {
                Console.WriteLine("Enter int numbers!");
                allIsOk = false;
            }
            catch (Exception exeption)
            {
                Console.WriteLine(exeption.Message);
                allIsOk = false;
            }

            if (allIsOk && min !=0 && max != 0)
            {
                var result = ReadNumber(min, max);
                Console.WriteLine("Your range = ");
                foreach(var item in result) { Console.WriteLine(item.ToString()); }
            }

        }

        static int Div(int a, int b)
        { return a / b; }

        static int[] ReadNumber(int min, int max)
        {
            int totalSizeArray = 5;
            int[] result = new int[totalSizeArray];

            for (int i = 0; i < totalSizeArray; i++)
            {
                while (true)
                {

                    bool allIsCorrect = true;
                    try
                    {
                        Console.Write($"Enter number in range #{i+1} = ");
                        int v = Int32.Parse(Console.ReadLine());

                        if (min < v && v < max)
                        {
                            result[i] = v;
                        }
                        else
                        {
                            throw new Exception($"Error! The number must be in range {min} ... {max}!");
                            allIsCorrect = false;
                        }

                    }
                    catch (FormatException exeption)
                    {
                        Console.WriteLine("Format exeption = " + exeption.Message);
                        allIsCorrect = false;
                    }
                    catch (Exception exeption)
                    {
                        Console.WriteLine("Total exeption = " + exeption.Message);
                        allIsCorrect = false;
                    }

                    if(allIsCorrect) { break; }

                }
            }

            return result;

        }

    }

}
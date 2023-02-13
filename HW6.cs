using System;
using System.Diagnostics.SymbolStore;

namespace homework
{
    internal class Task6
    {
        static void Main(string[] args)
        {
            //HW1();
            Hw2();
            //Hw3();
        }

        static void HW1()
        {
            int x = 0, y = 0;
            while(true)
            {
                bool trigger = false;
                try
                {
                    Console.Write("Enter the first integer: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the second integer: ");
                    y = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only digits!");
                    trigger = true;
                }
                if (!trigger) break;
            }
            Console.WriteLine($"x / y = {DivInt(x, y)}");

        }
        static double? DivInt(int x, int y)
        {
            double res=0;
            try
            {
                if (y == 0) throw new DivideByZeroException();
                res = (double) x / y;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division 0!");
                return null;
            }
            return res;
        }

        static void Hw2()
        {
            double x = 0, y = 0;
            while (true)
            {
                bool trigger = false;
                try
                {
                    Console.Write("Enter the first number: ");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the second number: ");
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only digits!");
                    trigger = true;
                }
                if (!trigger) break;
            }
            Console.WriteLine($"x / y = {DivDouble(x, y)}");
        }
        static double? DivDouble(double x, double y)
        {
            double res;   
            try
            {
                if (y == 0) throw new DivideByZeroException();
                res = x / y;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Division 0!");
                return null;
            }
            return res;
        }

        static void Hw3()
        {
        a:
            int min, max;
            
            try
            {
                Console.Write("Enter the min: ");
                min = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the max: ");
                max = Convert.ToInt32(Console.ReadLine());
                if (min > max) 
                    throw new Exception("Max must be bigger than min!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only digits!");
                goto a;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto a;
            }
            ReadNumber(min, max);
        }
        static int[] ReadNumber(int start, int end)
        {
            const int Size = 10;
            int[] res = new int[Size];
            for (int i = 0; i < res.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Enter {i + 1} number: ");
                    bool trigger = false;
                    try
                    {
                        res[i] = Convert.ToInt32(Console.ReadLine());
                        if (res[i] < start || res[i] > end)
                        {
                            throw new Exception("The number is out of range");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter only digits!");
                        trigger = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        trigger = true;
                    }
                    if (!trigger) break;
                }
                start = res[i];
            }
            return res;
        }
    }
}

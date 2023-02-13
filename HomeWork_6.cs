using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _20230208_HomeWork_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = -1;
            bool ok = false;

            while (!ok)
            {
                try
                {
                    Console.Write("Enter number 1: ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    b = int.Parse(Console.ReadLine());

                    c = a / b;
                    ok = true;
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }

            Console.WriteLine("\nResult: c = {0}", c);
            Console.ReadLine();
            Console.Clear();

            double d = 0;
            double e = 0;
            double f = -1;
            ok = false;

            while (!ok)
            {
                try
                {
                    Console.Write("Enter double number 1: ");
                    d = double.Parse(Console.ReadLine());

                    Console.Write("Enter number 2: ");
                    e = double.Parse(Console.ReadLine());
                    if (e == 0) {throw new DivideByZeroException(); }

                    f = d / e;
                    ok = true;
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }

            Console.WriteLine("\nResult: f = {0}", f);
            Console.ReadLine();
            Console.Clear();

            int[] source = new int[10];
            ok = false;
            int start = 0;
            int end = 101;

            while (!ok)
            {
                try
                {
                    for (int i = 0; i < source.Length; i++)
                    {
                        Console.Write("Enter number: ");
                        // int.TryParse(Console.ReadLine(), out source[i]);
                        source[i] = Convert.ToInt32(Console.ReadLine());

                        if (i == 0)
                            a = 0;
                        else
                        {
                            a = source[i - 1];
                        }

                        if (source[i] <= start || source[i] >= end || source[i] <= a) //
                        { throw new ApplicationException(); }
                    }

                    ok = true;

                }

                catch (ApplicationException)
                {
                    Console.WriteLine("Every next number must be > {0} end < {1}", start, end);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Error: {0}", ex.Message);
                }
            }

            Console.Write("\nSource: ");
            for (int i = 0; i < source.Length; i++)
            {
                Console.Write("{0}, ", source[i]);
            }
            Console.ReadLine();
        }
    }
}

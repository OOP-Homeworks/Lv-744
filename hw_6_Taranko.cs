using System;
using System.Globalization;
namespace hw_6_Taranko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int num1;
            int num2;
            double dnum1;
            double dnum2;
            bool succed1 = false;
            bool succed2 = false;
            while (!succed1) {
                Console.Write("Enter first integer : ");
                while (!Int32.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Enter correct first integer : ");
                }
                Console.Write("Enter second integer : ");
                while (!Int32.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Enter correct second integer : ");
                }

                try
                {
                    Console.WriteLine($"Result of dividing integers : {DivIntegers(num1, num2)}");
                    succed1 = true;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Dividing by zero , try again pls)");
                    succed1 = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    succed1 = false;
                }
            }

            ////Task2


            while (!succed2) {
                Console.Write("Enter first double : ");
                while (!Double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out dnum1))
                {
                    Console.Write("Enter correct first double : ");
                }
                Console.Write("Enter second double : ");
                while (!Double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out dnum2))
                {
                    Console.Write("Enter correct second double : ");
                }

                try
                {
                    Console.WriteLine($"Result of dividing doubles : {DivDoubles(dnum1, dnum2)}");
                    succed2 = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    succed2 = false;
                }
            }

            ////Task3
            int start = 0;
            int end = 0;
            bool succed3 = false;
            const int NUMOFNUMBERS = 10;
            while (!succed3) {
                Console.Write("Enter strrt : ");
                while (!Int32.TryParse(Console.ReadLine(), out start))
                {
                    Console.Write("Enter correct start integer : ");
                }
                Console.Write("Enter end : ");
                while (!Int32.TryParse(Console.ReadLine(), out end))
                {
                    Console.Write("Enter correct end integer : ");
                }
                if (end - start <= NUMOFNUMBERS)
                {
                    succed3 = false;
                }
                else {
                    succed3 = true;
                }
            }
            
            
            for (int i = 0; i < NUMOFNUMBERS; i++)
            {
                try {
                    start = ReadNumber(start, end);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                    i--;
                }
            }



        }
        static public int DivIntegers(int num1,int num2) {
            if(num1%num2 != 0)
            {
                throw new Exception("The result is not perfect");
            }
            return num1 / num2;
        }
        static public double DivDoubles(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new Exception("Dividing by zero , try again pls)");
            }
            return num1 / num2;
        }
        static public int ReadNumber(int start, int end)
        {
            Console.Write("Enter integer : ");
            int num;
            while (!Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.Write("Enter correct integer : ");
            }
            if (num < start) { 
                throw new Exception("Your number less than previous");
            }
            else if (num == start)
            {
                throw new Exception("Your number same to previous");
            }
            else if (num > end)
            {
                throw new Exception("Your number bigger than max");
            }
            else if (num == end)
            {
                throw new Exception("Your same to max");
            }
            return num;
        }
    }
}
using System;

namespace DivisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            try
            {
                int result = Div(num1, num2);
                Console.WriteLine("The result of the division is: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            
            //task 2
            Console.WriteLine("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            try
            {
                double result = Div2(num1, num2);
                Console.WriteLine("The result of the division is: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            
            
            //task 3
            
             int start = 1;
            int end = 100;
            int lastNumber = start;

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = ReadNumber(start, end);
                    if (number <= lastNumber)
                    {
                        throw new ArgumentException("Number must be greater than previous number.");
                    }
                    lastNumber = number;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    i--;
                }
              
        }

        static int Div(int num1, int num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();

            return num1 / num2;
        }
         static double Div2(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivideByZeroException();

            return num1 / num2;
        }
             static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter an integer between " + start + " and " + end + ": ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return number;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid number format.");
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Number must be between " + start + " and " + end + ".");
            }
        }
    }
}


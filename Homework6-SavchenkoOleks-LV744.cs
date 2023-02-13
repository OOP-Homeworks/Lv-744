using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace Homework6_SavchenkoOleks_LV744
{
    public enum TaskNumber
    {
        first,
        second
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
            //Task3();

        }
        static void Task1()
        {
            double? answer = null;
            while (answer == null)
            {
                Console.WriteLine("Please enter two numbers");
                string firstNumber = Console.ReadLine();
                string secondNumber = Console.ReadLine();
                answer = Div(firstNumber, secondNumber, TaskNumber.first);
            }
            Console.WriteLine($"The answer is {answer}");
        }
        static void Task2()
        {
            double? answer = null;
            while (answer == null)
            {
                Console.WriteLine("Please enter two numbers");
                string firstNumber = Console.ReadLine();
                string secondNumber = Console.ReadLine();
                answer = Div(firstNumber, secondNumber, TaskNumber.second);
            }
            Console.WriteLine($"The answer is {answer}");
        }
        static void Task3()
        {
            const int numberOfNumbers = 10;
            int[] resultArray = new int[numberOfNumbers];
        a1:
            try
            {
                Console.WriteLine("Please enter start number.");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter end number.");
                int end = int.Parse(Console.ReadLine());
                for(int i = 0; i < numberOfNumbers; i++)
                {
                    resultArray[i] = ReadNumber(start, end);
                    start = resultArray[i];
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter correct number!");
                goto a1;
            }
            Console.WriteLine("\nYour numbers are: ");
            foreach (int number in resultArray)
            {
                Console.WriteLine(number);
            }
        }

        static double? Div(string first, string second, TaskNumber task)
        {
            try
            {
                switch (task)
                {
                    case TaskNumber.first:

                        int firstNumberTask1 = int.Parse(first);
                        int secondNumberTask1 = int.Parse(second);
                        if (firstNumberTask1 % secondNumberTask1 != 0) throw new ArgumentException();
                        double resultTask1 = firstNumberTask1 / secondNumberTask1;
                        return resultTask1;
                    case TaskNumber.second:

                        double firstNumberTask2 = double.Parse(first);
                        double secondNumberTask2 = double.Parse(second);
                        if (secondNumberTask2 == 0) throw new DivideByZeroException();
                        double resultTask2 = firstNumberTask2 / secondNumberTask2;
                        return resultTask2;
                }
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You have divided by 0");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The result of divide is float number.");
            }
            return null;
        }

        static int ReadNumber(int start, int end)
        {
        s1:
            try
            {
                Console.WriteLine("Enter number");
                int number = int.Parse(Console.ReadLine());
                if (number <= start || number >= end) throw new InvalidDataException();
                return number;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                goto s1;
            }
            catch (InvalidDataException)
            {
                Console.WriteLine($"You should enter number between {start} and {end}");
                goto s1;
            }
        }
    }
}
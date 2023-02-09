using System.Collections.Concurrent;
using System.Diagnostics.Metrics;

namespace Lecture3_744;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Tasks #3:");
        showTask3();

        Console.WriteLine("Homework #3:");
        showHomework3();

        Console.ReadKey();

    }

    static void showTask3()
    {
        /// task 1
        /// 
        Console.Write("\nEnter int number 1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter int number 2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (a > b)
        {
            (a, b) = (b, a);
        }
        int count = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 3 == 0)
            {
                count++;
                Console.WriteLine($"{i}");
            }
        }
        Console.WriteLine($"How many integers in the range divided by 3? ={count}");

        /// task2
        ///
        Console.Write("\nEnter some string: ");
        string word = Console.ReadLine();
        word = " " + word;
        Console.WriteLine("Each second char is ");
        for (int i = 0; i < word.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{word[i]}");
            }
        }

        /// task3
        ///
        Console.Write("\nEnter the name of the drink (coffee, tea, juice, water): ");
        string drink = Console.ReadLine();
        switch (drink.ToLower())
        {
            case "coffee":
                Console.WriteLine($"{drink} cost 4$");
                break;
            case "tea":
                Console.WriteLine($"{drink} cost 2$");
                break;
            case "juice":
                Console.WriteLine($"{drink} cost 6$");
                break;
            case "water":
                Console.WriteLine($"{drink} cost 1$");
                break;
            default:
                Console.WriteLine("ops... wrong drink :(");
                break;
        }

        /// task 4
        ///
        Console.WriteLine("\nEnter a sequence of positive integers: ");
        
        int countSum = 0;
        int sum = 0;

        int currentNumber = Convert.ToInt32(Console.ReadLine());
        while (currentNumber >= 0)
        {
            countSum++;
            sum += currentNumber;
            currentNumber = Convert.ToInt32(Console.ReadLine());
        };
        Console.WriteLine($"{sum} / {countSum} = {sum/countSum}");

        /// task 5
        ///
        Console.Write("\nIs year a leap? Enter yaer: ");
        int yaer = Convert.ToInt32(Console.ReadLine());
        if (yaer % 4 == 0)
        {
            Console.WriteLine($"{yaer} is a leap!");
        }
        else
        {
            Console.WriteLine($"{yaer} is't a leap!");
        }

        /// task 6
        ///
        Console.Write("\nSum of digits. Enter int: ");
        string dString = Console.ReadLine();
        int sumDigits = 0;
        for (int i = 0; i < dString.Length; i++)
        {
            try
            {
                sumDigits += Convert.ToInt32(dString[i].ToString());
            }
            catch
            {
                Console.WriteLine($"symbol no#{i} doesn't digit!");
            }
        }
        Console.WriteLine($"Sum of digits = {sumDigits}");

        /// task 7
        ///
        Console.Write("\nOnly odd digits? Enter int: ");
        string numString = Console.ReadLine();
        bool isDigit = true;
        for (int i = 0; i < numString.Length; i++)
        {
            if (Convert.ToInt32(numString[i].ToString()) % 2 != 0)
            {
                Console.WriteLine($"{numString[i]} is not odd digit!");
                isDigit = false;
            }
        }
        if (isDigit) { Console.WriteLine("Is all only odd digits!"); }

    }

    static void showHomework3()
    {

        /// hw 1
        ///
        Console.Write("\nEnter some string with (a, o, i, e): ");
        string str = Console.ReadLine();
        char[] charArray = { 'a', 'o', 'i', 'e' };
        int countSymbInArray = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (charArray.Contains(str[i]))
            {
                countSymbInArray++;
            }
        }
        Console.WriteLine($"{countSymbInArray} a/o/i/e in string");

        /// hw 2
        ///
        Console.Write("\nEnter number of month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month > 0 && month <= 12)
        {
            Console.WriteLine($"Month #{month} contains #{daysInMonth[month - 1]} days");
        }

        /// hw 3
        ///
        Console.WriteLine("\n10 int numbers.");
        int[] arrNumb = new int[10];
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter number {i+1} / 10: ");
            arrNumb[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum_5 = 0;
        int product_5 = 1;
        bool needProduct = false;
        for (int i = 0; i < 10; i++)
        {
            if (i < 5)
            {
                sum_5 += arrNumb[i];
                if (arrNumb[i] < 0)
                {
                    needProduct = true;
                }
            }
            else
            {
                product_5 *= arrNumb[i];
            }
        }

        Console.WriteLine(needProduct ? product_5 : sum_5);

    }

}


using System;

namespace homework
{
    internal class HW3
    {
        static void Main(string[] args)
        {
            Hw1();
            Hw2();
            Hw3();
            Console.ReadKey();
        }

        static void Hw1()
        {
            char[] lettersToCount = {'a', 'o', 'i', 'e'}; 
            Console.WriteLine("Enter test :");
            string str = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for(int j=0; j<lettersToCount.Length; j++)
                {
                    if (str[i] == lettersToCount[j])
                    {
                        counter++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Number of letters (a, o, i, e): {counter}");
        }


        static void Hw2()
        {
            int[] daysOfMonthes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 30 };
            Console.Write("Enter the number of month: ");
            int userMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userMonth > daysOfMonthes.Length || userMonth < 1 ?
                                "You enterd incorrect month" : 
                                $"This month have {daysOfMonthes[userMonth-1]} days"
            );
        }

        static void Hw3()
        {
            Console.WriteLine("Enter 10 integers: ");
            int[] array = new int[10];
            bool isSum = true;
            int result = 0;

            for (int i = 0; i < 10; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (i < 5 && array[i] < 0) {
                    isSum = false;
                    result = 1;
                }
                _ = isSum && i < 5 ?
                        (result += array[i]) :
                        !isSum && i > 4 ? 
                            (result *= array[i]) : 
                            result += 0; // do nothing
            }
            Console.WriteLine($"The result = {result}");
        }
    }
}

using System;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string str = Console.ReadLine();
            int counter_a=0, counter_o=0, counter_i=0, counter_e=0;
            foreach (char c in str)
            {
                if (c=='a')
                    counter_a++;
                if (c=='o')
                    counter_o++;
                if (c=='i')
                    counter_i++;
                if (c=='e')
                    counter_e++;
            }
            Console.WriteLine("a: {0}, o: {1}, i: {2}, e: {3}", counter_a, counter_o, counter_i, counter_e);

            //2
            Console.WriteLine("Enter numerical value of month: ");
            byte month = byte.Parse(Console.ReadLine());
            byte[] days_in_month = new byte[12] {31,28,31,30,31,30,31,31,30,31,30,31};
            byte feb_add = 29;

            for (byte i = 0; i<= days_in_month.Length; i++)
            {
                if (i + 1 == month)
                {
                    if (month == 2)
                    {
                        Console.WriteLine(days_in_month[i] + "/" + feb_add);
                        break;
                    }
                Console.WriteLine(days_in_month[i]);
                }
            }

            //3
            int[] inties = new int[10];
            bool first_five_are_positive = true;
            int sum5f = 0, prod5l = 0;
            for (int i=0; i<=9; i++)
            {
                inties[i] = int.Parse(Console.ReadLine());
                if (inties[i] < 0 && i < 5)
                {
                    first_five_are_positive = false;
                }
                else if (i < 5)
                {
                    if (i > 4)
                        continue;
                    sum5f += inties[i];
                }
                else
                    if (i == 5)
                        prod5l = inties[i];
                    else
                        prod5l *= inties[i];
            }
            if (first_five_are_positive == true)
                Console.WriteLine(sum5f);
            else
                Console.WriteLine(prod5l);
        }
    }
}
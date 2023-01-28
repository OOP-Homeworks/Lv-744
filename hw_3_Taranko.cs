using System;


namespace hw_3_Taranko
{
    internal class Program
    {
        struct Month {
            public int number;
            public int daysCount;
            public Month(int number, int daysCount) {
                this.number = number;
                this.daysCount = daysCount;
            }
        }
        static void Main(string[] args)
        {
            ////Task1
            string str;
            int count1 = 0;
            Console.WriteLine("Enter string :");
            str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == 'a' || str[i] == 'o' || str[i] == 'i' || str[i] == 'e') {
                    count1++;
                }
            }
            Console.WriteLine($"Result - {count1}");
            Console.WriteLine("\n\n\n");

            ////Task2
            
            Month[] monthh = new Month[12] { new Month(1, 31), new Month(2, 28), new Month(3, 31), new Month(4, 30), new Month(5, 31), new Month(6, 30), new Month(7, 31), new Month(8, 31), new Month(9, 30), new Month(10, 31), new Month(11, 30), new Month(12, 31), };
            int monthNum;
            int res;
            Console.WriteLine("Enter month num :");
            while (!Int32.TryParse(Console.ReadLine(), out monthNum) || monthNum < 0 || monthNum > 12 )
            {
                Console.WriteLine("Enter correct month num");
            }
            for (int i = 0; i < 12; i++)
            {
                if (monthh[i].number == monthNum) {
                    Console.WriteLine("Result - {0}",monthh[i].daysCount);
                    break;
                }

            }
            Console.WriteLine("\n\n\n");

            ////Task3

            int[] mass = new int[10];
            int sum3 = 0;
            int prod3 = 1;
            bool pos = true;
            for (int i = 0; i < mass.Length; i++) {
                Console.WriteLine("Enter {0} number",i+1);
                while (!Int32.TryParse(Console.ReadLine(), out mass[i]))
                {
                    Console.WriteLine("Enter correct number");
                }
                if (i < 5 && pos && mass[i] > 0)
                {
                    sum3 += mass[i];
                }
                else if (i < 5 && pos && mass[i] <= 0) {
                    pos = false;
                }
                else if (i >= 5 && !pos)
                {
                    prod3 *= mass[i];
                }
            }
            if (pos) 
            {
                Console.WriteLine("Sum of first 5 = {0}", sum3);
            }
            else 
            {
                Console.WriteLine("Prod of second 5 = {0}", prod3);
            }
            Console.ReadLine();

        }
    }
}

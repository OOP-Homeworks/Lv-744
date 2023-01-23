using System;

namespace HW_2_2023
{
    class Program
    {
        enum HttpErrors
        { error400, error401, error402, error403 };
        struct Cat
        {
            string name;
            string mark;
            int age;
            public void getCatInfo(string n, string m, int a)
            {
                name = n;
                mark = m;
                age = a;

            }
            public void outPut()
            {
                Console.WriteLine("Name : {0}", name);
                Console.WriteLine("Mark : {0}", mark);
                Console.WriteLine("Age : {0}", age);
            }
        }

        static void Main(string[] args)
        {
            //Task_1

            Console.WriteLine("Enter 3 float variables : ");
            float input1 = Convert.ToSingle(Console.ReadLine());
            float input2 = Convert.ToSingle(Console.ReadLine());
            float input3 = Convert.ToSingle(Console.ReadLine());
            float minValue = -5, maxValue = 5;
            Console.WriteLine(input1 < minValue && input1 > maxValue ? $"First var in renge" : "First var out of renge");
            Console.WriteLine(input2 < minValue && input2 > maxValue ? $"Second var in renge" : "Second var out of renge");
            Console.WriteLine(input3 < minValue && input3 > maxValue ? $"Third var in renge" : "Third var out of renge");

            //Task_2

            Console.WriteLine("\nEnter 3 integer symbols : ");
            int maxInt, minInt;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(maxInt = a > b ? a : (b > c ? b : c));
            Console.WriteLine(minInt = a < b ? a : (b < c ? b : c));

            //Task_3

            Console.WriteLine("\nEnter Http error cod : ");
            int error = Convert.ToInt32(Console.ReadLine());
            HttpErrors badRequest = HttpErrors.error400;
            HttpErrors unautorized = HttpErrors.error401;
            HttpErrors paymentRequired = HttpErrors.error402;
            HttpErrors forbidden = HttpErrors.error403;

            switch (error)
            {
                case 400:
                    Console.WriteLine($"{ badRequest}, Bad Request");
                    break;
                case 401:
                    Console.WriteLine($"{ unautorized}, Unautorized");
                    break;
                case 402:
                    Console.WriteLine($"{ paymentRequired}, PaymentRequired");
                    break;
                case 403:
                    Console.WriteLine($"{ forbidden}, Forbidden");
                    break;
            }

            //Task_4

            Console.WriteLine("\nCat Info");
            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            cat1.getCatInfo("Charlie", "Home", 12);
            cat2.getCatInfo("Elise", "Scotland", 8);
            cat1.outPut();
            cat2.outPut();



        }
    }
}

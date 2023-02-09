
﻿using System;

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
=======
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task_5_2_2023
{
    class Program
    {



        static void Main(string[] args)
        {
            List<int> myColl = new List<int> { -10, 10, -10, 10, 24, -20, -10, 6, 10, 55 };

            for (int i = 0; i < myColl.Count; i++)
            {
                    
                if (i == myColl.IndexOf(-10))
                {
                    Console.WriteLine($"Integer -10 at position :{i} ");
                    myColl.Remove(myColl[i]);
                    myColl.Insert(i, 10);
                }
            }            
            //myColl = myColl.Select((value, index) => new { value, index }).Where(x => x.value == -10).Select(x => x.index).ToList();
            myColl.Insert(2, 1);
            myColl.Insert(8, -3);
            myColl.Insert(5, -4);
            myColl.RemoveAll(x => x > 20);
            myColl.Sort();
            foreach (int item in myColl)
            {
                Console.Write(" | " + item);
            }
          

        }
    }
}


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

{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.Input();
            Car car2 = new Car();
            car2.Input();
            Car car3 = new Car();
            car3.Input();
            car1.Output();
            car2.Output();
            car3.Output();
            Console.Write("Enter sale percent : ");
            double percent = Convert.ToDouble(Console.ReadLine());
            car1.ChangePrice(percent);
            car2.ChangePrice(percent);
            car3.ChangePrice(percent);
            Console.Write("Car data after change price SALE :");
            car1.Output();
            car2.Output();
            car3.Output();
            Console.Write("Enter color to repaint white cars : ");
            string newColor = Console.ReadLine();
            car1.Repaint(car1, newColor);
            car2.Repaint(car2, newColor);
            car3.Repaint(car3, newColor);
            car1.Output();
            car2.Output();
            car3.Output();
            Console.WriteLine("Checking same cars in garage : ");
            if (car1 == car2) Console.WriteLine($"Same cars{car1.name} & {car2.name}");
            else if (car1 == car3) Console.WriteLine($"Same cars {car1.name} & {car3.name}");
            else if (car2 == car3) Console.WriteLine($"Same cars {car2.name} & {car3.name} ");
            else Console.WriteLine("Not the same car ");





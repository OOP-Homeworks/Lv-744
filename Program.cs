using System;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hw1();
            Hw2();
            Hw3();
            Hw4();
            Console.ReadKey();
        }


        static void Hw1()
        {
            float x = (float)Convert.ToDouble(Console.ReadLine());
            float y = (float)Convert.ToDouble(Console.ReadLine());
            float z = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((Math.Abs(x) > 5) ? "The number x is out of range" :
                              (Math.Abs(y) > 5) ? "The number y is out of range" :
                              (Math.Abs(z) > 5) ? "The number z is out of range" :
                              "Everything is fine"
            );
        }


        static void Hw2()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(x, Math.Max(y, z));
            int min = Math.Min(x, Math.Min(y, z));
            Console.WriteLine($"max : {max}, min : {min}");
        }


        enum HTTPError1xx {Continue=100, Switching_protocols, Processing, Early_Hints};
        static void Hw3()
        {
            Console.Write("Enter the code of error (100-103): ");
            int code = Convert.ToInt32(Console.ReadLine());
            if (code < 100 || code > 103) Console.WriteLine("The code you entered doesn't fit");
            else
            {
                HTTPError1xx error = (HTTPError1xx)code;
                Console.WriteLine($"The error is: {error}");
            }
        }


        struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public override string ToString()
            {
                return string.Format($"Dog {name}, {age} y.o., mark: {mark}");
            }
        }
        static void Hw4()
        {
            Dog myDog;
            Console.Write("Enter dog's name: ");
            myDog.name = Console.ReadLine();
            Console.Write("Enter dog's mark: ");
            myDog.mark = Console.ReadLine();
            Console.Write("Enter dog's age: ");
            myDog.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(myDog);
        }

    }
}
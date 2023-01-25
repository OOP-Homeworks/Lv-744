using System;
using System.Globalization;

namespace hw_2_Taranko
{
    internal class Program
    {
        //Task1_Consts
        public const int COUNT_OF_CHACKING_RANGE = 3;
        public const float MIN_OF_CHACKING_RANGE = -5.0f;
        public const float MAX_OF_CHACKING_RANGE = 5.0f;
        //Task1_Consts
        public const int COUNT_OF_MIN_MAX_CHACKING = 3;
        //Task3_Enum
        enum HttpErors {
            Informational,
            Successful,
            Redirect,
            Client,
            Server
        }
        //Task4_Struct
        public struct Dog
        {
            public string name;
            public int mark;
            public int age;

            public Dog(string name, int mark, int age)
            {
                this.name = name;
                this.mark = mark;
                this.age = age;
            }
            public override string ToString() => $"(Name - {name}, Mark - {mark}, Age - {age})";
        }
        static void Main(string[] args)
        {
            //Task1
            float num;
            for (int i = 0; i < COUNT_OF_CHACKING_RANGE; i++) {
                Console.Write("Enter float numer : ");
                while (!float.TryParse(Console.ReadLine().Replace(',', '.').Replace(".0",""), NumberStyles.Float ,
                    CultureInfo.InvariantCulture, out num)){

                    Console.Write("Enter correct float numer : ");
                }
                RangeChecker(num, MIN_OF_CHACKING_RANGE, MAX_OF_CHACKING_RANGE);
            }
            Console.Write("\n\n\n");
            //Task2
            int[] inrArr = new int[COUNT_OF_MIN_MAX_CHACKING];
            for (int i = 0; i < COUNT_OF_MIN_MAX_CHACKING; i++) {
                Console.Write("Enter int numer : ");
                while (!int.TryParse(Console.ReadLine(), out inrArr[i]))
                {
                    Console.Write("Enter correct float numer : ");
                }
            }
            MinMaxChecker(inrArr);
            Console.Write("\n\n\n");
            //Task3
            int erorNum;
            Console.Write("Enter error numer : ");
            while (!int.TryParse(Console.ReadLine(), out erorNum))
            {
                Console.Write("Enter correct int numer : ");
            }
            HttpErrorChecker(erorNum);
            Console.Write("\n\n\n");
            //Task4
            string name;
            int mark;
            int age;
            Console.Write("Enter dog's name : ");
            name = Console.ReadLine();
            Console.Write("Enter dog's mark : ");
            while (!int.TryParse(Console.ReadLine(), out mark))
            {
                Console.Write("Enter correct dog's mark : ");
            }
            Console.Write("Enter dog's age : ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Enter correct dog's age : ");
            }
            Dog dog1 = new Dog(name, mark, age);
            Console.WriteLine("{0}",dog1.ToString());
            Console.ReadLine();
        }
        //Task1_Func
        static void RangeChecker(float num, float min, float max)
        {
            if (num >= min && num <= max)
            {
                Console.WriteLine("Nunber {0} is in range [{1} ; {2}]", num, min, max);
            }
            else {
                Console.WriteLine("Nunber {0} isn't in range [{1} ; {2}]", num, min, max);
            }
        }
        //Task2_Func
        static void MinMaxChecker(int[] inrArr)
        {
            int min = inrArr[0];
            int max = inrArr[0];
            for (int i = 0; i < inrArr.Length; i++) {
                if (inrArr[i] < min)
                {
                    min = inrArr[i];
                }
                else if (inrArr[i] > max) {
                    max = inrArr[i];
                }
            }
            Console.WriteLine("Min number : {0} , Max number {1}", min, max);
        }
        //Task3_Func
        static void HttpErrorChecker(int erorNum)
        {
            if (erorNum >= 100 && erorNum <= 199)
            {
                Console.WriteLine("{0} error", HttpErors.Informational);
            }
            else if (erorNum >= 200 && erorNum <= 299)
            {
                Console.WriteLine("{0} error", HttpErors.Successful);
            }
            else if (erorNum >= 300 && erorNum <= 399)
            {
                Console.WriteLine("{0} error", HttpErors.Redirect);
            }
            else if (erorNum >= 400 && erorNum <= 499)
            {
                Console.WriteLine("{0} error", HttpErors.Client);
            }
            else if (erorNum >= 500 && erorNum <= 599)
            {
                Console.WriteLine("{0} error", HttpErors.Server);
            }
            else {
                Console.WriteLine("No such error");
            }
        }
    }
}

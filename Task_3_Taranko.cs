using System;


namespace Task_3
{
    struct Drinks {
        public string name;
        public int price;

        public Drinks(string name, int price) {
            this.name = name;
            this.price = price;
        }
        public override string ToString()
        {
            return name + " , price : " + price.ToString();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /////Task1
            
            int a;
            int b;
            int countt = 0;
            Console.WriteLine("Enter a :");
            while (!Int32.TryParse(Console.ReadLine(), out a)) {
                Console.WriteLine("Enter correct a");
            }
            Console.WriteLine("Enter b :");
            while (!Int32.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Enter correct b");
            }
            for (int i = a; i <= b; i++) {
                if (i % 3 == 0) {
                    countt++;
                }
            }
            Console.WriteLine($"Answer - {countt}");
            Console.WriteLine("\n\n\n");
            



            /////Task2

            string text;
            Console.WriteLine("Enter text :");
            text = Console.ReadLine();
            for (int i = 1; i < text.Length; i = i + 2) {
                Console.WriteLine(text[i]);
            }
            Console.WriteLine("\n\n\n");

            /////Task3

            Drinks[] drinks = new Drinks[4] {new Drinks("coffe",40)  , new Drinks("tea", 20) , new Drinks("juice", 25), new Drinks("water", 5) };
            string drinkName;
            Console.WriteLine("Enter name of drink :");
            drinkName = Console.ReadLine();
            switch (drinkName) {
                case "coffe":
                    Console.WriteLine(drinks[0].ToString());
                    break;
                case "tea":
                    Console.WriteLine(drinks[1].ToString());
                    break;
                case "juice":
                    Console.WriteLine(drinks[2].ToString());
                    break;
                case "water":
                    Console.WriteLine(drinks[3].ToString());
                    break;
                default:
                    Console.WriteLine("No such drink");
                    break;

            }
            Console.WriteLine("\n\n\n");
            /////Task4

            uint sum = 0;
            int num;
            Console.WriteLine("Enter int num :");
            while (!Int32.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Enter correct num");
            }
            while (num > 0) {
                sum += (uint)num;
                Console.WriteLine("Enter int num :");
                while (!Int32.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Enter correct num");
                }
            }
            Console.WriteLine($"Result - {sum}");
            Console.WriteLine("\n\n\n");

            /////Task5
            Console.WriteLine("Enter year :");
            int year;
            while (!Int32.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Enter correct year");
            }
            if (year % 4 == 0)
            {
                Console.WriteLine($"{year} - Leap year");
            }
            else {
                Console.WriteLine($"{year} - Not a leap year");
            }
            Console.WriteLine("\n\n\n");

            /////Task6

            Console.WriteLine("Enter integer number :");
            int num2;
            int sum2 = 0;
            while (!Int32.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Enter correct num");
            }
            while (num2 > 0) {
                sum2 += num2 % 10;
                num2 = num2 / 10;
            }
            Console.WriteLine("Result - {0}", sum2);
            Console.WriteLine("\n\n\n");

            /////Task7

            Console.WriteLine("Enter integer number :");
            int num3;
            while (!Int32.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Enter correct num");
            }
            while (num2 > 0)
            {
                if (num2 / 2 == 0)
                {
                    num2 = num2 / 10;                  
                }
                else {
                    Console.WriteLine("Negative");
                    break;
                }                
            }
            if (num2 == 0)
            {
                Console.WriteLine("Positive");
            }
            Console.ReadLine();
        }
    }
}

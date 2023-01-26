using System;

internal class Program
{
    private static void Main(string[] args)
    {
        showTask1();
        showHomework1();
    }

    static void showTask1()
    { 
        /// T A S K - 1

        ///=======================================
        /// 1.1
        /// 
        Console.WriteLine("\n1.1 Int type");

        Console.Write("Enter a=");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter b=");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        Console.WriteLine($"{a} / {b} = {a/b}");

        ///=======================================
        /// 1.2
        /// 
        Console.WriteLine("\n1.2 String type");

        Console.WriteLine("How are you?");
        string answer = Console.ReadLine();
        Console.WriteLine("You are {0}", answer);

        ///=======================================
        /// 1.3
        /// 
        Console.WriteLine("\n1.3 Char type");
        Console.WriteLine("Please enter 3 char:");

        char a_char = char.Parse(Console.ReadLine());
        char b_char = char.Parse(Console.ReadLine());
        char c_char = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("You enter (first {0}), (second {1}), (3 {2})", a_char, b_char, c_char);

        Console.WriteLine("And last one:");

        if (char.TryParse(Console.ReadLine(), out char result))
        {
            Console.WriteLine("It's char");
        }
        else
        {
            Console.WriteLine("It's don't char");
        }

        ///=======================================
        /// 1.4
        ///
        Console.WriteLine("\n1.4 Bool type");

        Console.WriteLine("Please enter 2 numbers:");
        int k = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        bool isNumbersPositive = false;

        if (k > 0 && l > 0)
        {
            isNumbersPositive = true;
        }
        Console.WriteLine("Numbers are both positive = {0}", isNumbersPositive);

    }

    static void showHomework1()
    {

        /// H O M E W O R K - 1

        ///=======================================
        /// 1.1
        ///
        Console.WriteLine("\n1.1 Enter side of the square:");

        double side = Convert.ToDouble(Console.ReadLine());
        double s1 = Math.Pow(side,2);
        Console.WriteLine($"Area = {s1:N2}");
        double p1 = 4 * side;
        Console.WriteLine($"Perimeter = {p1:N2}");

        ///=======================================
        /// 1.2
        ///
        Console.WriteLine("\n1.2 What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"How old are you, {name}?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your age is {age}");

        ///=======================================
        /// 1.3
        ///
        Console.WriteLine("\n1.3 Enter radius of a circle:");
        double radius = Convert.ToDouble(Console.ReadLine());

        double l3 = 2 * Math.PI * radius;
        Console.WriteLine($"Lenght = {l3:N2}");

        double s3 = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Area = {s3:N2}");

        double v3 = (4 / 3) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Volume = {v3:N2}");


    }

}
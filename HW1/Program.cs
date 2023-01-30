﻿namespace HW_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int sq_area = a * a;
            int sq_perimeter = 4 * a;
            Console.WriteLine("Area is {0} and perimeter is {1}.", sq_area, sq_perimeter);

            string name;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine().ToString();
            Console.WriteLine("How old are you, {0}?", name);
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(name + " is {0} yo.", age);

            double r, length, area, volume;
            r = Convert.ToDouble(Console.ReadLine());
            length = 2 * Math.PI * r;
            area = Math.PI * r * r;
            volume = (4 * Math.PI * r * r * r) / 3;
            Console.WriteLine("For such circle length, area, volume are {0:N2} {1:N2} {2:N2} respectfully.", length, area, volume);
        }
    }
}
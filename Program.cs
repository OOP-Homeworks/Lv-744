using System;

namespace lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hw1();
            //Hw2();
            //Hw3();
        }

        static void Hw1()
        {
            Console.Write("Enter a side of the square: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int area = a * a;
            int perimetr = a * 4;
            Console.WriteLine($"The area of square = {area}\n"+
                              $"The perimetr = {perimetr}"
            );
        }
        
        static void Hw2()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"How old are you, {name}");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and you are {age} y.o.");
        }

        static void Hw3()
        {
            Console.Write("Enter a radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());
            double length = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            double volume = 4/3 * Math.PI * r * r * r;
            Console.WriteLine($"The length = {length}\n"+
                              $"The area = {area}\n" +
                              $"The volume = {volume}"
            );
        }
    }

 

}
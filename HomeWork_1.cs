using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230119_HomeWork_1​​
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:  ");
            string userName = Console.ReadLine();
            Console.Clear();

            string result;
            bool ok = false;
            int userAge = 0;

            while (ok != true)
            {
                Console.Write("Enter your age:  ");
                result = Console.ReadLine();
                ok = int.TryParse(result, out userAge);
                Console.Clear();
            }
            
            Console.WriteLine("Hello {0}, you are {1} years old!", userName, userAge);
            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();
            Console.Clear();


            Console.Write("Enter the length of the side of the square:  ");
            result = Console.ReadLine();
            Console.Clear();

            int squareSide;

            ok = int.TryParse(result, out squareSide);

            if (ok)    // True
            {
                int squareArea = squareSide * squareSide;
                int squarePerimeter = squareSide * 4;

                Console.WriteLine("If the side of a square = {0}", squareSide);
                Console.WriteLine("Area of a square = {0}, perimeter of a square = {1}", squareArea, squarePerimeter);
                Console.Write("\nPress any key to contiune...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error, it's not a number");
                Console.Write("\nPress any key to contiune...");
                Console.ReadKey();
            }

            Console.Clear();

            
            Console.Write("Enter the radius of a circle:  ");
            result = Console.ReadLine();
            Console.Clear();

            double circleRadius;

            ok = double.TryParse(result, out circleRadius);

            if (ok)    // True
            {
                double circleArea = Math.PI * circleRadius * circleRadius;
                double circleLength = 2 * Math.PI * circleRadius;
                double circleVolume = 4 / 3 * Math.PI * circleRadius * circleRadius * circleRadius;

                Console.WriteLine("If the radius of the circle = {0}", circleRadius);
                Console.WriteLine("Area of a circle = {0}, length of a circle = {1}, volume of a circle = {2}", circleArea, circleLength, circleVolume);
                Console.Write("\nPress any key to contiune...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Error, it's not a number");
                Console.Write("\nPress any key to contiune...");
                Console.ReadKey();
            }
            Console.Clear();

            int a = 3;
            int b = 8;
            int c = 10;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            a += c;
            c = a - c;
            a -= c;
            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);

            a ^= c;
            c ^= a;
            a ^= c;
            a ^= b;
            b ^= a;
            a ^= b;

            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.Clear();
                    //1 task
                    Console.Write("Enter a value: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine(a * 4);
                    Console.WriteLine(3.14159265358979323846 * a * a);

                    //2 task
                    Console.Write("What is your name?: ");
                    string name = Console.ReadLine();
                    Console.Write($"How old are you? {name}: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Your name is {name} and you are {age}");


                    //3 task
                    Console.Write("Enter a value: ");
                    double r = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The length is {2 * 3.14 * r}, area is {r * r * Math.PI}, volume is {4 / 3 * 3.14 * r * r * r}.");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            //Task_1

            int area, perimeter, side;
            Console.Write("Enter square side : ");
            side = int.Parse(Console.ReadLine());

            perimeter = side * 2;
            area = (int)Math.Pow(side,2);
            Console.WriteLine($"Area = {area}, perimeter = {perimeter}");

            //Task_2

            string name;
            int age;
            Console.WriteLine("\nHi, what is your name ? ");
            name = Console.ReadLine();
            Console.WriteLine($"How old are you {name} ?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and you {age} years old.");

            //Task_3

            double radius, length, area1, volume;

            Console.Write("\nEnter circle radius : ");
            radius = Convert.ToDouble(Console.ReadLine());
            length = Math.Round((2 * Math.PI * radius), 2);
            area1 = Math.Round(( Math.PI * Math.Pow(radius, 2)), 2);
            volume = Math.Round(( 4/3 * Math.PI * Math.Pow(radius, 3)),2);
            Console.WriteLine($"We have circle with volume {volume}, length {length} and area {area1}");

        }
    }
}


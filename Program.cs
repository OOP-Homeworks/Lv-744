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
                    Console.WriteLine($"The length is {2 * 3.14 * r}, area is {r * r * 3.14}, volume is {4 / 3 * 3.14 * r * r * r}.");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




        }





    }
}


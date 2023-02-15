using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;

namespace homework
{
    internal class HW8
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();
            Console.WriteLine("Enter data about shapes, to stop press 'b'");
            do
            {
                Console.Write("To enter circle put 'c', to enter square put 's': ");
                string data = Console.ReadLine();
                if (data[0] == 'c')
                {
                    Console.Write("Enter the name of circle: ");
                    string name = Console.ReadLine();
                    list.Add(new Circle(name, ReadNumber.Double("Enter the radius: ")));
                }
                else if (data[0] == 's')
                {
                    Console.Write("Enter the name of square: ");
                    string name = Console.ReadLine();
                    list.Add(new Square(name, ReadNumber.Double("Enter the side: ")));
                }
                else if (data[0] == 'b') break;
            }while(true);

            Hw1(list);
            Console.WriteLine();
            Hw2(list);
            Console.WriteLine();
            Hw3(list);
        }
        static void Hw1(List<Shape> list)
        {
            foreach (Shape shape in list)
                Console.WriteLine
                (
                    "The {0} named {1}. Area = {2}, perimetr = {3}",
                    (shape.GetType() == typeof(Square) ? "square" : "circle"),
                    shape.Name, shape.Area(), shape.Perimetr()
                );
        }
        static void Hw2(List<Shape> list)
        {
            int max = 0;
            string name = "";
            foreach (Shape shape in list)
            {
                if(shape.Perimetr()>max) name = shape.Name;
            }
            Console.WriteLine(name);
        }
        static void Hw3(List<Shape> list)
        {
            list.Sort();
            Hw1(list);
        }
    }




}


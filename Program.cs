using System;
using System.Collections.Generic;

namespace HW_8_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxPerimetr = 0.0;
            List<Shapes> shapes = new();
            shapes.Add(new Square("square1", 8, "Big"));
            shapes.Add(new Square("square2", 3, "Small"));
            shapes.Add(new Square("square3", 6, "Medium"));
            shapes.Add(new Circle("circle1", 2, "Small"));
            shapes.Add(new Circle("circle2", 5, "Medium"));
            shapes.Add(new Circle("circle3", 12, "Big"));
            foreach (var item in shapes)
            {
                item.Print();
            }
            Console.WriteLine("Enter name of shape to find it : ");
            string input = Console.ReadLine();
            foreach (var item in shapes)
            {
                if (item.Name == input)
                {
                    item.Print();
                }
            }
            foreach (Shapes s in shapes)
            {
                if (maxPerimetr <= s.Perimeter())
                {
                    maxPerimetr = s.Perimeter();
                }
            }
            foreach (Shapes o in shapes)
            {
                if (maxPerimetr == o.Perimeter())
                {
                    Console.WriteLine($"Name: {o.Name}, with max perimetr:{o.Perimeter():###.##} ");
                }
            }
            shapes.Sort();
            foreach (var item in shapes)
            {
                Console.WriteLine($"Shape : {item} with perimeter : {item.Perimeter():###.##}");
            }
        }
    }
}

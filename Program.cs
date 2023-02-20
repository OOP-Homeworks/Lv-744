using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
                Console.WriteLine($"Shape : {item.Name} with perimeter : {item.Perimeter():###.##}");
            }

            //HW9
            string path = @"C:\Users\judai\source\repos\HW_8_2023\HW_8_2023\shapes.txt";
            try
            {
                FileInfo fileInfo = new(path);
                if (!(fileInfo.Exists))
                {
                    fileInfo.Create();
                }
                using StreamWriter sw = new(path, false, System.Text.Encoding.Default);
                {
                    var newShapes = shapes.Where(x => x.Area() > 10 && x.Area() < 100);
                    sw.WriteLine("Shapes with Area from 10 to 100 :");
                    foreach (var item in newShapes)
                    {
                        sw.WriteLine($"Name : {item.Name} with area {item.Area():F2} and perimeter {item.Perimeter():F2}");
                    }
                    var selctedShapes = shapes.Where(y => y.Name.Contains('a'));
                    foreach (var item in selctedShapes)
                    {
                        Console.WriteLine($"Name contain symbol 'a' : {item}");
                    }
                    var smallPerimeter = shapes.Where(z => z.Perimeter() < 15);
                    foreach (var item in smallPerimeter)
                    {
                        Console.WriteLine($"Shapes with perimeter < 15 : \n{item}");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

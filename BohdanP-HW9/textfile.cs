using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace HW8
{
    internal class Program
    {
        static void Main()
        {
            string path = @"C:\Users\MrB\source\repos\HW9\";

            Shape[] arrOfShapes =
            { new Circle("Type Babl C1" , 0.64), new Circle("Type Babl C2", 2.3), new Circle("Type C5", 5), 
                new Square("Type S6", 6.05), new Square("Type S10", 10.12) };
            List<Shape> shapes = arrOfShapes.Where(p => p != null).ToList();

            double[] shapeAreaArray = shapes.Select(i => i.GetArea).ToArray();
            File.WriteAllLines(path + "selected.txt", from ar in shapeAreaArray where (ar>10 && ar<100) select ar.ToString());

            ////Можна вибрати щось з LINQ і REGEX
            //IEnumerable<string> selectedNames = shapes.Where(sh => Regex.IsMatch(sh.GetName, @"a")).Select(shape => Regex.Match(shape.GetName, @"a").Value);

            foreach (var s in shapes)
            {
                if (s.GetName.Contains('a'))
                    File.AppendAllText(path + "selected.txt", s.GetName + Environment.NewLine);
            }

            List<Shape> selectedShapes = shapes.Where(sh => sh.GetPerimeter > 5).ToList();
            foreach (var s in selectedShapes) { Console.WriteLine(s.GetName + " " + s.GetPerimeter); }
        }
    }
}
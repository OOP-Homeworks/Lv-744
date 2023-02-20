

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230216_HomeWork_8
{
    internal class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            int[] shapePossible = new int[11];

            for (int i = 0; i < 10; i++)
            {
                if (rnd.Next(0, 2) == 0)
                {
                    shapes.Add(new Circle("Circle", rnd.Next(1, 11)));
                }
                else
                {
                    shapes.Add(new Square("Square", rnd.Next(1, 11)));
                }
            }

            Console.WriteLine("________________\n");

            foreach (Shape shape in shapes)
            {
                shape.Print();
            }

            Console.WriteLine("________________\n");

            Shape maxPerimeterShape = shapes[0];

            for (int i = 1; i < shapes.Count; i++)
            {
                if (shapes[i].Perimeter() > maxPerimeterShape.Perimeter())
                {
                    maxPerimeterShape = shapes[i];
                    
                }
            }

            Console.WriteLine($"Shape with max perimeter is:");
            maxPerimeterShape.Print();
            
            Console.WriteLine("________________\n");

            shapes.Sort();

            foreach (Shape shape in shapes)
            {
                shape.Print();

}
}
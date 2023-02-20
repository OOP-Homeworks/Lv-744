using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace homework
{
    internal class HW_A
    {
        private static Random random = new Random();
        private const int SIZE = 6;
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public static void General()
        {
            IList<Shape> shapes = new Shape[SIZE];
            
            for (int i = 0; i < SIZE; i++)
            {
                shapes[i] = random.Next() % 2 == 0 ? 
                    new Square(RandomString(random.Next(4, 8)), random.Next(1, 300)) : 
                    new Circle(RandomString(random.Next(4, 8)), random.Next(1, 300));
            }

            string writePath_A2 = "shapesInRange_10-100.txt";
            Hw_A2(shapes, writePath_A2);

            string writePath_A3 = "shapesContains_a.txt";
            Hw_A3(shapes, writePath_A3);

            shapes = Hw_A4(shapes);
            foreach (Shape shape in shapes)
                Console.WriteLine(shape);
        }

        static void Hw_A2(IList<Shape> shapes, string writePath)
        {
            using (var file = new StreamWriter(writePath, false))
            {
                foreach (Shape shape in shapes.Where(a => a.Area()>=10 || a.Area()<=100))
                        file.WriteLine(shape);
            }
        }

        static void Hw_A3(IList<Shape> shapes, string writePath)
        {
            using (var file = new StreamWriter(writePath, false))
            {
                Regex myReg = new Regex(@"['a']+");
                foreach (Shape shape in shapes.Where(a => myReg.IsMatch(a.Name)))
                        file.WriteLine(shape);
            }
        }

        static IList<Shape> Hw_A4(IList<Shape> shapes)
        {
            IEnumerable<Shape> new_shapes = from i in shapes
                                      where i.Perimetr() >= 5
                                      select i;
            return new_shapes.ToList();
        }
    }
}


﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._02._2023_HomeWork_9
{
    internal class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            /*A) Create Console Application project.
                   Use classes Shape, Circle, Square from your previous homework.
                   Use Linq and string functions to complete next tasks:
                   1) Create list of Shape and fill it with 6 different shapes (Circle and Square).*/

            List<Shape> shapes = new List<Shape>();

            int[] shapePossible = new int[11];

            for (int i = 0; i < shapePossible.Length; i++)
            {
                shapePossible[i] = rnd.Next(0, 21);

                if (shapePossible[i] <= 11)
                {
                    shapes.Add(new Circle("Circle", shapePossible[i]));
                }
                else if (shapePossible[i] >= 11)
                {
                    shapes.Add(new Square("Square", shapePossible[i]));
                }
            }

            foreach (Shape shape in shapes)
            {
                shape.Print();
            }

            // 2) Find and write into the file shapes with area from range [10,100]

            Console.WriteLine("\n\nShapes 10-100:");
            IEnumerable<Shape> shapesInRange = shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100);
            foreach (Shape shape in shapesInRange)
            {
                shape.Print();
            }

            // 3) Find and write into the file shapes which name contains letter 'a'

            Console.WriteLine("\n\nNames with 'a':");
            IEnumerable<Shape> shapesWithA = shapes.Where(shape => shape.Name.Contains('a'));
            foreach (Shape shape in shapesWithA)
            {
                shape.Print();
            }


            // 4) Find and remove from the list all shapes with perimeter less then 5. Write resulted list into Console 

            Console.WriteLine("\n\nPerimeter not 15:");
            shapes.RemoveAll(shape => shape.Perimeter() < 15);
            foreach (Shape shape in shapes)
            {
                shape.Print();
            }

            Console.WriteLine();
            Console.ReadLine();
        }

    }
}

using System.Globalization;
using System;
using System.Collections.Generic;

namespace hw_8_Taranko
{
    internal class hw_8_TARANKO
    {
        const int COUNTOFSHAPES = 10;
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>(COUNTOFSHAPES);
            for (int i = 0; i < COUNTOFSHAPES / 2; i++) {
                double tempRadious = 0;
                Console.WriteLine($"Enter radious of {i+1} circle : ");

                while (!Double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out tempRadious)) {
                    Console.WriteLine($"Enter correct radious of {i+1} circle : ");
                }
                shapeList.Add(new Circule(tempRadious, "Circle"));
            }

            for (int i = 0; i < COUNTOFSHAPES / 2; i++)
            {
                double tempSide = 0;
                Console.WriteLine($"Enter side of {i + 1} square : ");

                while (!Double.TryParse(Console.ReadLine().Replace(',', '.'), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out tempSide))
                {
                    Console.WriteLine($"Enter correct side of {i + 1} square : ");
                }
                shapeList.Add(new Square(tempSide, "Square"));
            }
            Console.WriteLine("\n\n\n");
            for (int i = 0; i < shapeList.Count; i++) {
                Console.WriteLine(shapeList[i]);
            }
            
            maxPerimeter(shapeList);

            shapeList.Sort();

            Console.WriteLine("\n\n\nSorted :\n\n");
            for (int i = 0; i < shapeList.Count; i++)
            {
                Console.WriteLine(shapeList[i]);
            }
        }

        static void maxPerimeter(List<Shape> shapeList) {
            Shape temp_max = shapeList[0];
            for (int i = 1; i < shapeList.Count; i++) {
                if (shapeList[i].Perimeter() > temp_max.Perimeter()) {
                    temp_max = shapeList[i];
                }
            }
            Console.WriteLine($"\n\n\nMax perimeter:\n\n{temp_max}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_SavchenkoOleks_LV744
{
    public class Triangle
    {
        Point vertex1, vertex2, vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }

        public double Perimeter()
        {
            return Math.Round(vertex1.Distance(vertex2) + vertex2.Distance(vertex3) + vertex3.Distance(vertex1), 2);
        }

        public bool IsTriangleCorrect()
        {
            double side1 = vertex1.Distance(vertex2);
            double side2 = vertex2.Distance(vertex3);
            double side3 = vertex3.Distance(vertex1);
            if (Perimeter() - side1 <= side1 || Perimeter() - side2 <= side2 || Perimeter() - side3 <= side3) return false;
            else return true;
        }

        public double Square()
        {
            double p = Perimeter() / 2;
            double firstSide = vertex1.Distance(vertex2);
            double secondSide = vertex2.Distance(vertex3);
            double thirdSide = vertex3.Distance(vertex1);
            return Math.Round(Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide)), 2);
        }

        public void Print()
        {
            Console.WriteLine($"Triangle with vertexes: {vertex1}, {vertex2}, {vertex3}" +
                              $"Perimeter is {Perimeter()}, Square is {Square()}");
        }
    }
}

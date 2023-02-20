using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soft
{
    public class Triangle : Program
    {
        public Point vertex1;
        public Point vertex2;
        public Point vertex3;

        public Triangle(Point s1, Point s2, Point s3) 
        { 
            vertex1 = s1;
            vertex2 = s2;
            vertex3 = s3;
        }
        public double Distance(Point x, Point y) 
        {
            double distx = x.x - y.x;
            double disty = x.y - y.y;
            return Math.Sqrt(distx * distx + disty * disty);
        }
        public double Perimeter() 
        {
            return Distance(vertex1, vertex2) + Distance(vertex2, vertex3) + Distance(vertex3, vertex1);
        }

        public double Square()
        {
            double a = Distance(vertex1, vertex2);
            double b = Distance(vertex2, vertex3);
            double c = Distance(vertex3, vertex1);
            double perimeter = Perimeter() / 2;
            return Math.Sqrt(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c));
        }
        public void Print()
        {
            Console.WriteLine($"Triangle v: {vertex1}, {vertex2}, {vertex3}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine($"Square: {Square()}");
        }
    }
}


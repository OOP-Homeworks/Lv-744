using System;

namespace HW_10_2023
{
    public struct Point
    {
        public int x, y;
        public Point(int x, int y) { this.x = x; this.y = y; }
        public double Distance(Point point)
        {
            return Math.Round(Math.Sqrt(Math.Pow(x - point.x, 2) + Math.Pow(y - point.y, 2)), 1);
        }
    }
    public class Triangle
    {
        private Point point, point1, point2;
        public Triangle(Point a, Point b, Point c)
        { point = a; point1 = b; point2 = c; }
        public double Perimeter()
        {
            return point.Distance(point1) + point1.Distance(point2) + point2.Distance(point);
        }
        public double Square()
        {
            double halfPer = Perimeter() / 2;
            return Math.Round(Math.Sqrt(halfPer * (halfPer - point.Distance(point1)) *
                (halfPer - point1.Distance(point2)) * (halfPer - point2.Distance(point))), 1);
        }
        public void Print()
        {
            Console.WriteLine($"Triangle perimeter {Perimeter()} and square {Square()}");
        }


    }
}

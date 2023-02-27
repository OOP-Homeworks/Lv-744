using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class Triangle
    {
        //Program.Point vertex1, vertex2, vertex3;

        public Triangle(Program.Point p1, Program.Point p2, Program.Point p3)
        {
            Print(p1,p2,p3);
        }

        public double Distance(Program.Point p1, Program.Point p2)
        {
            double AC, BC;
            AC = Math.Abs(p2.x - p1.x);
            BC = Math.Abs(p2.y - p1.y);
            return Math.Sqrt(Math.Pow(AC,2)+Math.Pow(BC,2));
        }
        public double Perimeter(Program.Point p1, Program.Point p2, Program.Point p3) 
        {
            return Distance(p1, p2) + Distance(p2, p3) + Distance(p3, p1);
        }
        public double Square(Program.Point p1, Program.Point p2, Program.Point p3)
        {
            double halfp = Perimeter(p1, p2, p3) / 2;
            return Math.Sqrt(halfp*(halfp-Distance(p1,p2)*(halfp-Distance(p2,p3)*(halfp-Distance(p3,p1)))));
        }
        public void Print(Program.Point p1, Program.Point p2, Program.Point p3)
        {
            Console.WriteLine("Perimeter: " + Perimeter(p1, p2, p3));
            Console.WriteLine("Square area: " + Square(p1, p2, p3));
        }
    }
}

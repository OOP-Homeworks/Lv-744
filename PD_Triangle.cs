using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.h_w
{
    public class PD_Triangle
    {
        PD_Point vertex1, vertex2, vertex3;
        //, side2, side3;
        public PD_Triangle(PD_Point vertex1, PD_Point vertex2, PD_Point vertex3)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.vertex3 = vertex3;
        }
        public bool CheckValidness()
        {
            if(Perimetr() - Sides().Max() <= Sides().Max())
            {
                throw new ArgumentException("The sum of 2 sides is lower than 3rd side");
            }
            return true;
        }
        
        public double[] Sides()
        {
            double[] sides = {vertex1.Distance(vertex2), 
                                vertex2.Distance(vertex3), 
                                vertex3.Distance(vertex1) };
            return sides;
        }
        public double Perimetr()
        {
            double[] sides = Sides();
            return sides[0] + sides[1] + sides[2];
        }
        public double Square()
        {
            double[] sides = Sides();
            double p = Perimetr() / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }
        public override string ToString()
        {
            return string.Format("The triangle with a perimetr = {0:F3}, ", Perimetr()) +
                string.Format("square = {0:F3}, is build on vertexes {1}, {2}, {3}", 
                                Square(), vertex1, vertex2, vertex3); 
        }
        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}

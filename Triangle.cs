using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23022023_HomeWork_10
{
    public class Triangle
    {
        private readonly Point vertex1;
        private readonly Point vertex2;
        private readonly Point vertex3;

        public Triangle(Point vertex1, Point vertex2, Point vertex3)
        {
            this.vertex1 = vertex1 ?? throw new ArgumentNullException(nameof(vertex1));
            this.vertex2 = vertex2 ?? throw new ArgumentNullException(nameof(vertex2));
            this.vertex3 = vertex3 ?? throw new ArgumentNullException(nameof(vertex3));

            if (!IsValid())
            {
                throw new ArgumentException("Invalid triangle sides");
            }
        }

        public double[] GetSides()
        {
            double[] sides = { vertex1.Distance(vertex2), vertex2.Distance(vertex3), vertex3.Distance(vertex1) };
            return sides;
        }

        public double GetPerimeter()
        {
            double[] sides = GetSides();
            return sides.Sum();
        }

        public double GetArea()
        {
            double[] sides = GetSides();
            double p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }

        public bool IsValid()
        {
            double[] sides = GetSides();
            return sides[0] + sides[1] > sides[2] &&
                   sides[1] + sides[2] > sides[0] &&
                   sides[2] + sides[0] > sides[1];
        }

        public override string ToString()
        {
            return $"The triangle with a perimeter = {GetPerimeter():F3}, " +
                   $"area = {GetArea():F3},\nis built on vertices {vertex1}, {vertex2}, {vertex3}";
        }

        public void Print()
        {
            Console.WriteLine(this);
        }
    }
}


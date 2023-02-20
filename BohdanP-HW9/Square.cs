using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8
{
    internal sealed class Square : Shape
    {
        private double side;
        private readonly string shapeName = "Square";

        public Square(string name, double side) : base(name, side)
        {
            this.side = side;
            base.name = name;
            Console.WriteLine("Square area is {0} and perimeter is {1}", Math.Round(Area(), 2), Math.Round(Perimeter(), 2));
        }

        public override double Area()
        {
            double area = Math.Pow(side, 2);
            return area;
        }

        public override double Perimeter()
        {
            double perimeter = 4 * side;
            return perimeter;
        }

        public override double GetArea { get { return Area(); } }
        public override double GetPerimeter { get { return Perimeter(); } }

        public override int CompareTo(object obj)
        {
            return GetArea.CompareTo(obj);
        }
    }
}

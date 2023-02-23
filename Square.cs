using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._02._2023_HomeWork_9
{
    internal class Square : Shape
    {
        private double side;

        public Square(string name, double side) : base("Square")
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return 4 * side;
        }
    }
}

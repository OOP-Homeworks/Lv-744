using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    internal class Square : Shape
    {
        public double Side { get; set; }

        public Square(string name, double side) : base(name)
        {
            this.Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2);
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
}

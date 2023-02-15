using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Square : Shape
    {
        double side;
        public double Side
        {
            get { return side; }
            set { if (side > 0) side= value; }
        }
        public Square(string name, double side) : base(name)
        { if (side > 0) this.side = side; }
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimetr()
        {
            return 2 * side;
        }
    }
}

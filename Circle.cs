using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}

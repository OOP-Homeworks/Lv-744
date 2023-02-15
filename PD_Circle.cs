using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Circle : Shape
    {
        double radius;
        public double Radius
        { 
            get { return radius;} 
            set { if (radius > 0) radius = value;} 
        }
        public Circle(string name, double radius) : base(name) 
        { if(radius > 0) this.radius = radius;}
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double Perimetr()
        {
            return 2 * Math.PI * radius;
        }
    }
}

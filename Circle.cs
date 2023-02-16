using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_2023
{
    class Circle : Shapes
    {
        private int radius;
        private string size;
        public int Radius { get { return radius; } }
        public string Size { get { return size; } }

        public Circle(string name, int radius, string size) : base(name)
        {
            this.size = size;
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Radius * Math.PI; 
        }
        public override void Print()
        {
            Console.WriteLine("Circle method Print:\n{0} have Area : {1:###.##} and Perimeter :{2:###.##} Size {3}", Name, Area(), Perimeter(), size);
        }


    }
}

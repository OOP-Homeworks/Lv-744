using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_8_Taranko
{
    internal class Square_Taranko : Shape_Taranko , IComparable
    {
        double side;
        public Square_Taranko(double side, string name) : base(name)
        {
            this.side = side;
        }
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public override double Area()
        {
            return Math.Pow(side, 2);
        }
        public override double Perimeter()
        {
            return 4 * side;
        }

        public override string ToString()
        {
            return $"Shape : {this.Name}\t\tArea : {this.Area():f3}\t\tPerimeter : {this.Perimeter():f3}";
        }
        public int CompareTo(object o)
        {
            if (o.GetType() == this.GetType())
            {
                Square_Taranko temp = (Square_Taranko)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }
            else
            {
                Circule_Taranko temp = (Circule_Taranko)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }
        }
    }
}

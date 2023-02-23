using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_8_Taranko
{
    internal class Circule_Taranko : Shape_Taranko , IComparable
    {
        double radious;
        public Circule_Taranko(double radious , string name) : base(name)
        {
            this.radious = radious;
        }

        public double Radious {
            get { return radious; }
            set { radious = value; }
        }

        public override double Area() {
            return Math.PI * Math.Pow(radious, 2);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radious;
        }

        public override string ToString()
        {
            return $"Shape : {this.Name}\t\tArea : {this.Area():f3}\t\tPerimeter : {this.Perimeter():f3}";
        }

        public int CompareTo(object o)
        {
            if (o.GetType() == this.GetType())
            {
                Circule_Taranko temp = (Circule_Taranko)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }
            else
            {
                Square_Taranko temp = (Square_Taranko)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }          
        }
    }
}

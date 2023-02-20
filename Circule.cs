using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_8_Taranko
{
    internal class Circule : Shape , IComparable
    {
        double radious;
        public Circule(double radious , string name) : base(name)
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
                Circule temp = (Circule)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }
            else
            {
                Square temp = (Square)o;
                if (temp.Area() < this.Area())
                {
                    return 1;
                }
                return -1;
            }          
        }
    }
}

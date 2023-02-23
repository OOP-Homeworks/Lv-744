using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10_SavchenkoOleks_LV744
{
    public struct Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(double x1, double y1)
        {
            return Math.Sqrt(Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2));
        }
        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow((p.x - x), 2) + Math.Pow((p.y - y), 2));
        }
        public override string ToString()
        {
            return String.Format("({0},{1})", x, y);
        }
    }
}

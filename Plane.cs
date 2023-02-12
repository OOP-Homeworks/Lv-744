using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_744
{
    internal class Plane: IFlyable , IComparable<Plane>
    {
        string mark;
        int hightFly;
        public void Fly()
        {
            Console.WriteLine($"Info about Plane. Mark={mark} highFly={hightFly}");
        }
        public Plane(string mark, int hightFly)
        {
            this.mark = mark;
            this.hightFly = hightFly;
        }

        public int CompareTo(Plane other)
        {
            return hightFly - other.hightFly;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_2023
{
    abstract class Shapes:IComparable<Shapes>   
    {
        public string name;
        public string Name { get { return name; }}
        public Shapes(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public virtual void Print()
        {
            Console.WriteLine("Shape is : {0}", this.name);
        }
        public int CompareTo(Shapes other)
        {
            Shapes shape = other as Shapes;
            if (shape != null)
                return this.Perimeter().CompareTo(shape.Perimeter());
            else
                throw new NotImplementedException("Shape does not exist");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_9_Taranko_A
{
    abstract class Shape_Taranko9
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Shape_Taranko9(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_8_Taranko
{
    abstract class Shape 
    {
        string name;
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public Shape(string name)
        {
            this.name = name;
        }

        public abstract double Area();
        public abstract double Perimeter();


    }
}

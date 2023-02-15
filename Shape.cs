using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    abstract class Shape
    {
        string name;

        public string Name { get; set; }

        public Shape(string name) 
        {
            this.name = name;
        }
        public abstract double Area();
        public abstract double Perimeter();
        
        
    }
}

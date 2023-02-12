using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HW_5
{
    class Programmer : IDeveloper, IComparable
    {
        public string Tool { get { return lenguage; } set { lenguage = value; } }
        public void Create() 
        {
            Console.WriteLine($"{name} programming by {this.lenguage}");
        }
        public void Destroy() 
        {
            Console.WriteLine($"{name} destroy code by {this.lenguage}");
        }

        string lenguage, name;
        public Programmer (string name, string lenguage) 
        {
            this.name = name;
            this.lenguage = lenguage;
        }
        public int CompareTo(object o)
        {
            Programmer p = o as Programmer;
            Builder b = o as Builder;
            if (p != null)
                return this.Tool.CompareTo(p.Tool);
            else if (b != null)
                return this.Tool.CompareTo(b.Tool);
            else
                throw new ArgumentException("Object is not a Programmer");
        }
    }
}

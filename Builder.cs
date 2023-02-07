using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    class Builder : IDeveloper, IComparable
    {
      
        public string Tool { get { return tool; } set { tool = value; } }
        public void Create() 
        {
            Console.WriteLine($"{name} build  program by {this.tool}");
        }
        public void Destroy() 
        {
            Console.WriteLine($"{name} destroy without any {this.tool}");
        }

        string tool;
        string name;
        public Builder(string name, string tool)
        {
            this.name = name;
            this.tool = tool;

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
                throw new ArgumentException("Object is not a developer");
        }

        
    }
}

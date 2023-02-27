using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _26022023_HomeWork_10Person
{
    public class Developer : Staff
    {
        public string LangProgam { get; }

        public Developer(string name, string langProgam, int salary) : base(name, salary)
        {
            LangProgam = langProgam;
        }

        public override void Print()
        {
            Console.WriteLine("{0} - {1}: ${2}", Name, LangProgam, Salary);
        }

        public override void Display()
        {
            Console.WriteLine("Developer: {0} - '{1}'", Name, LangProgam);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230215_HW_Task_8
{
    internal class Developer : Staff
    {
        public string LangProgam;
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

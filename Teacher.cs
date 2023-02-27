using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26022023_HomeWork_10Person
{
    public class Teacher : Staff
    {
        private string position;

        public Teacher(string name, string position, int salary) : base(name, salary)
        {
            this.position = position;
        }

        public override void Print()
        {
            Console.WriteLine("{0} - {1}: ${2}", Name, position, Salary);
        }

        public override void Display()
        {
            Console.WriteLine("Teacher: {0} - '{1}'", Name ?? "unknown", position ?? "unknown");
        }
    }

}

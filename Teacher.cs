using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _20230215_HW_Task_8
{
    internal class Teacher : Staff
    {
        public string Position { get; set; }

        public Teacher(string name, string position, int salary) : base(name, salary)
        {
            Position = position;
        }

        public override void Print()
        {
            Console.WriteLine("{0} - {1}: ${2}", Name, Position, Salary);
        }

        public override void Display()
        {
            Console.WriteLine("Teacher: {0} - '{1}'", Name, Position);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230215_HW_Task_8
{
    abstract class Staff : Person, IComparable<Staff>
    {
        private int salary;
        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }
        public int Salary { get { return salary; } }

        public int CompareTo(Staff p)
        {
            Staff d = p as Developer;
            Staff t = p as Teacher;
            if (d != null)
                return this.salary.CompareTo(d.salary);
            else if (t != null)
                return this.salary.CompareTo(t.salary);
            else
                throw new Exception("Unable to compare two objects");
        }

        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: {1}", Name, Salary);
        }

        public override void Display()
        {
            Console.WriteLine("Staff: {0} salary ${1}\n", Name, salary);
        }
    }
}

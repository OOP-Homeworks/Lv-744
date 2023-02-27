using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26022023_HomeWork_10Person
{
    public class Staff : Person, IComparable<Staff>
    {
        private int salary;
        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        public int Salary { get { return salary; } }

        public int CompareTo(Staff otherStaff)
        {
            return new StaffSalaryComparer().Compare(this, otherStaff);
        }

        public virtual void Print()
        {
            Console.WriteLine("Person {0} has salary: {1}", Name, Salary);
        }

        public virtual void Display()
        {
            Console.WriteLine("Staff: {0} salary ${1}\n", Name, salary);
        }

        private class StaffSalaryComparer : IComparer<Staff>
        {
            public int Compare(Staff x, Staff y)
            {
                return x.Salary.CompareTo(y.Salary);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230215_HW_Task_8
{
    abstract class Person : IComparable
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        virtual public string Name { get { return name; } }
        
        public virtual int CompareTo(object obj1)
        {
            Person p1 = obj1 as Person;
            if (p1 == null)
                throw new ArgumentException("Not a Person");
            else
                return Name.ToLower().CompareTo(p1.Name.ToLower());
        }

        public virtual void Print()
        {
            Console.WriteLine("Person: {0}", name);
        }

        public virtual void Display()
        {
            Console.WriteLine("Hi, {0}", Name);
        }
    }
}

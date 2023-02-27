using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26022023_HomeWork_10Person
{
     public class Person : IComparable<Person>
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public virtual string Name { get { return name; } }

        public virtual int CompareTo(Person other)
        {
            if (other == null)
                throw new ArgumentException("Not a Person");
            else
                return Name.ToLower().CompareTo(other.Name.ToLower());
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

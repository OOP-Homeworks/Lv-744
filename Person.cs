using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe
{
    internal class Person
    {
        private string name;
        private int birthYears;

        public string Name
        {
            get { return name; }
        }
        public int Years 
        {
            get { return birthYears; }
        }

        public Person() 
        {

        }
        public int Age() 
        {
            birthYears = Years + Years;
            return birthYears;
        }
        public void Input() 
        {
           Console.WriteLine("Enter a name:");
           name = Console.ReadLine();
           Console.WriteLine("Enter age: ");
           birthYears = int.Parse(Console.ReadLine());
        }
        public void ChangeName()
        {
            Console.WriteLine("You can change your name: ");
            name = Console.ReadLine();
            if (birthYears < 16) 
            {
                Console.WriteLine("Very Young");
            }
        }
        public override string ToString()
        {
            return $"{name},{birthYears}";
        }
        public void Output() 
        {
            ToString();
        }

        public static bool  operator ==(Person person, Person person1) 
        {
            return person.Name == person1.Name;

        }
        public static bool operator !=(Person name, Person name1)
        {
            return !(name.Name != name1.Name);
        }






    }
}

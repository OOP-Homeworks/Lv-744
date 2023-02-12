using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Lecture4_744
{
	public class Person
	{
		private string name;
        private DateTime birthYear;

		public string Name
		{
			get { return name; }
		}

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person() {}

        public Person(string _name, DateTime _birthYear)
        {
			name = _name;
			birthYear = _birthYear;
        }

        public int Age()
        {
            var now = DateTime.Today;
            long diff = now.Ticks - birthYear.Ticks;
            DateTime yearDiff = new DateTime(diff);
            int age = yearDiff.Year;

            return age;

        }

        public void ChangeName(string _name) { name= _name; }
        
        public override string ToString()
        {
            return $"Name: {name} BirthYear: {birthYear.ToString("D")}";
        }

        public string Output()
        { 
            return this.ToString() ;
        }

        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }

        public static bool operator !=(Person first, Person second)
        {
            return first.name != second.name;
        }

    }
}


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_2023
{
    class Person
    {
        string name;
        int birthYear;
        public string Name { get { return name; } private set { name = value; } }
        public int BirthYear
        {
            get { return birthYear; }
            private set
            {
                if (value > 2022 && value < 1922)
                {
                    Console.WriteLine("Year format exeption");
                }
            }
        }
        public Person() { }
        public Person(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }
        public int Age()
        {
            int age = 2023 - birthYear;
            Console.WriteLine(name + birthYear + age);
            return age;
        }
        public  void ChangeName(string newName)
        {
            name = newName;
        }
        public override string ToString()
        {
            return string.Format($" Name: {name} birthyear : {birthYear.ToString("yyyy")} ");
        }
        public static bool operator ==(Person person1, Person person2)
        {
            return person1.name == person2.name;
        }
        public static bool operator !=(Person person1, Person person2)
        {
            return person1.name != person2.name;
        }
        public void  Output()
        {
            Console.WriteLine($" Name : {name} year : {birthYear}");
        }
        public static Person Input()
        {
            Person p = new Person();
            Console.Write("Enter persons name : ");
            string name = Console.ReadLine();
            p.name = name;
            Console.Write("Enter birth year : ");
            int year = Convert.ToInt32((Console.ReadLine()));
            p.birthYear = year;
            
            return p;

        }
    }
}

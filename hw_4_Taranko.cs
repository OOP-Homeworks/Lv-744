using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_4_Taranko
{
    class Person {
        //Fields

        string name;
        DateTime birthYear;

        //Properties

        public string Name { get { return name; } set { } }
        public DateTime BirthYear { get { return birthYear; } set { } }

        //Consructors

        public Person() {
            name = null;
            birthYear = DateTime.MinValue;
        }
        public Person(string name, string birthYear)
        {
            this.name = name;
            this.birthYear = DateTime.ParseExact(birthYear, "d/mm/yyyy", null);
        }

        //Methods

        public int Age() {
            return (DateTime.Now.Month > birthYear.Month) ? DateTime.Now.Year - birthYear.Year - 1 : (DateTime.Now.Month < birthYear.Month) ? DateTime.Now.Year - birthYear.Year : (DateTime.Now.Day > birthYear.Day) ? DateTime.Now.Year - birthYear.Year - 1 : DateTime.Now.Year - birthYear.Year;
        }
        public void Input(){
            Console.WriteLine("Enter name of person :");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter date of birth person (dd/mm/yyyy):");
            while (!DateTime.TryParseExact(Console.ReadLine(), "d/mm/yyyy", null, DateTimeStyles.None, out this.birthYear)) {
                Console.WriteLine("Enter CORRECT date of birth person (dd/mm/yyyy):");
            }
            


        }
        public void ChangeName(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return $"name {this.name} , birth year {birthYear.Year}";
        }
        public void Output()
        {
            Console.WriteLine(ToString());
        }
        public static bool operator == (Person p1, Person p2) {
            if (p1.name == p2.name) {
                return true;
            }
            return false;
        }
        public static bool operator != (Person p1, Person p2)
        {
            if (p1.name != p2.name)
            {
                return true;
            }
            return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] pers = new Person[6];
            pers[0] = new Person("Taras" , "26/11/2004");
            pers[1] = new Person("Famas", "01/01/2002");
            pers[2] = new Person("Kiras", "07/10/2001");
            pers[3] = new Person("Paras", "22/02/2010");
            pers[4] = new Person("Horas", "05/07/2007");
            pers[5] = new Person("Garase", "20/03/2020");

            for (int i = 0; i < pers.Length; i++) {
                pers[i].Output();
                Console.WriteLine("Age - {0}",pers[i].Age());
            }
            Console.WriteLine("\n\nYoungest :");
            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i].Age() < 16)
                {
                    pers[i].ChangeName("Very young");
                }
                pers[i].Output();
            }
            Console.WriteLine("\n\n");
            for (int i = 0;i< pers.Length; i++)
            {
                for (int b = i + 1; b < pers.Length; b++) {
                    if (pers[i] == pers[b]) {
                        Console.WriteLine("Same :");
                        pers[i].Output();
                        pers[b].Output();
                        Console.WriteLine("\n\n");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

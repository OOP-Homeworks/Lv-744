using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _20230131_HomeWork_4
{
    /* Define class Person. Class Person should consist of:
                a) two private fields: name and birthYear (the birthday year).
		(As a type for this field you may use DataTime type.)
                b) two properties for access to these fields (can use only get)
                c) default constructor and constructor with 2 parameters 
                d) methods: - Age() - to calculate the age of person
                   	    - Input() - to enter data about person from console
                  	    - ChangeName() - to change the name of person
                 	    - ToString() 
                   	    - Output() - to output information about person (call ToString())
                 	    - operator== (equal by name)
        In the method Main() create 6 objects of Person type and enter information about them. 
        Then calculate and output on the console name and Age of each person; 
        Change the name of persons, which Age is less then 16, to "Very Young".
        Output information about all persons on the console. 
        Find and output information about Persons with the same names (use ==).	*/

    class Person
    {
        private string namePerson = "No Name";
        private int birthYear = 2015;
        private int yourAge;
        int minimalAge = 16;

        public Person()
        {

        }

        public Person(string namePerson, int birthYear)
        {
            this.namePerson = namePerson;
            this.birthYear = birthYear;
        }

        public static bool operator ==(Person a, Person b)
        {
            return a.namePerson == b.namePerson;
        }

        public static bool operator !=(Person a, Person b)
        {
            return !(a == b);
        }

        public string ChangeName
        {
            get { return namePerson; }
        }

        public void ChangeName16()
        {
            if (yourAge <= minimalAge) namePerson = "Very young";
        }

        public int ChangeAge
        {
            get { return yourAge = DateTime.UtcNow.Year - birthYear; }
        }

        public override string ToString()
        {
            return $"Name: {namePerson} Birth year: {birthYear}";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Person onePerson = new Person();
            Person twoPerson = new Person("Andrew", 1988);
            Person threePerson = new Person("Mickhael", 1967);
            Person fourPerson = new Person();
            Person fivePerson = new Person("Bob", 2001);
            Person sixPerson = new Person("Antonio", 1995);

            Console.WriteLine("1. {0}\n\n2. {1}\n\n3. {2}\n\n4. {3}\n\n5. {4}\n\n6. {5}\n\n", onePerson.ToString(), twoPerson.ToString(),
                     threePerson.ToString(), fourPerson.ToString(), fivePerson.ToString(), sixPerson.ToString());
            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Name: {0} your age {1}\n", onePerson.ChangeName, onePerson.ChangeAge);
            Console.WriteLine("Name: {0} your age {1}\n", twoPerson.ChangeName, twoPerson.ChangeAge);
            Console.WriteLine("Name: {0} your age {1}\n", threePerson.ChangeName, threePerson.ChangeAge);
            Console.WriteLine("Name: {0} your age {1}\n", fourPerson.ChangeName, fourPerson.ChangeAge);
            Console.WriteLine("Name: {0} your age {1}\n", fivePerson.ChangeName, fivePerson.ChangeAge);
            Console.WriteLine("Name: {0} your age {1}\n", sixPerson.ChangeName, sixPerson.ChangeAge);
            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();
            Console.Clear();

            onePerson.ChangeName16();
            twoPerson.ChangeName16();
            threePerson.ChangeName16();
            fourPerson.ChangeName16();
            fivePerson.ChangeName16();
            sixPerson.ChangeName16();

            Console.WriteLine("1. {0}\n\n2. {1}\n\n3. {2}\n\n4. {3}\n\n5. {4}\n\n6. {5}\n\n", onePerson.ToString(), twoPerson.ToString(),
                     threePerson.ToString(), fourPerson.ToString(), fivePerson.ToString(), sixPerson.ToString());
            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();
            Console.Clear();

            if (onePerson == fourPerson) Console.WriteLine("The same names: {0} = {1}", onePerson.ChangeName, fourPerson.ChangeName);
            else Console.WriteLine("Not the same names: {0} = {1}", onePerson.ChangeName, fourPerson.ChangeName);

            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
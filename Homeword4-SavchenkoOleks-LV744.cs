using System;

namespace Homework4_SavchenkoOleks_LV744
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = 6;
            Person[] people = new Person[numberOfPeople];
            Console.WriteLine("Please enter the information about all the people: ");
            for (int i = 0; i < numberOfPeople; i++)
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter birth year: ");
                int birthYear = int.Parse(Console.ReadLine());
                people[i] = new Person(name, birthYear);
            }

            Console.WriteLine("\nList of People");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine("\nList people who are older than 16 y. o.");
            foreach (var person in people)
            {
                if (person.Age() < 16) person.ChangeName("Very Young");
                Console.WriteLine(person);
            }
            Console.WriteLine("\n");
            for(int i = 0; i < numberOfPeople; i++)
            {
                for(int j = i + 1; j < numberOfPeople; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine("Here is a pair of people with the same name: ");
                        Console.WriteLine(people[i]);
                        Console.WriteLine(people[j]);
                    }
                }
            }
        }
    }
    class Person
    {
        private string name;
        private int birthYear;
        public string Name { get { return name; } }
        public int BitthYear { get { return birthYear; } }
        public Person() : this("Unknown", DateTime.Now.Year)
        {
            
        }
        public Person(string name, int birthYear)
        {
            this.name = name;
            this.birthYear = birthYear;
        }

        public int Age()
        {
            return DateTime.Now.Year - birthYear;
        }
        public void Input(string name, int birthYear)
        {
            this.name = Name;
            this.birthYear = birthYear;
        }
        public override string ToString()
        {
            return $"Name is {name}, age is {Age()}(born in {birthYear})";
        }
        public void Output()
        {
            ToString();
        }
        public static bool operator == (Person person1, Person person2)
        {
            return person1.name == person2.name;
        }
        public static bool operator != (Person person1, Person person2)
        {
            return !(person1 == person2);
        }
        public void ChangeName(string NewName)
        {
            name = NewName;
        }
    }
}
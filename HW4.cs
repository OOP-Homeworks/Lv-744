using System;

namespace homework
{
    class Person
    {
        string name;
        public string Name 
        {   
            get { return name; }
            set { }
        }

        DateTime birthday = new DateTime();
        public DateTime Birthday
        {
            get { return birthday; }
            set { }
        }

        public Person() : this("Unknown", (DateTime.Now))
        { }
        public Person(string name, DateTime birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public int Age()
        {
            return DateTime.Now.Year - birthday.Year -
                   ((DateTime.Now.Month < birthday.Month) ? 1 :
                    (DateTime.Now.Month > birthday.Month) ? 0 :
                    (DateTime.Now.Day < birthday.Day) ? 1 : 0);                                           ;
        }


        public void Input()
        {
            Console.WriteLine("Enter data about the person (Name, date of birth(dd-mm-yyyy)): ");
            name = Console.ReadLine();
            birthday = Convert.ToDateTime(Console.ReadLine());
        }
        public void ChangeName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"Person: {name}, {Age()} y.o., " +
                   $"birthday: {birthday.Date.ToShortDateString()}";
        }
        public void Output() { Console.WriteLine(ToString());}
        public static bool operator == (Person a, Person b)
        {
            return a.name == b.name;
        }
        public static bool operator != (Person a, Person b)
        {
            return a.name != b.name;
        }

    }

    internal class HW4
    {
        const int Size = 6;
        const string NameYoungUser = "Very young";
        static Person[] people = new Person[Size];
        
        static void Main(string[] args)
        {
            //Task 1
            for(int i = 0; i < people.Length; i++)
            {
                people[i] =new Person();
                people[i].Input();
            }
            Console.WriteLine();

            //Task 2
            foreach (Person i in people) i.Output();
            Console.WriteLine();

            //Task 3
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16) people[i].ChangeName(NameYoungUser);
            }

            //Task 4
            foreach (Person i in people) i.Output();
            Console.WriteLine();

            //Task 5
            Task5(people);
        }

        static void Task5(Person[] people)
        {
            int[] usedNames = new int[people.Length];
            int counter = 0;

            for (int i = 0; i < people.Length - 1; i++)
            {
                bool triggerWriteName = false;
                for (int j = i + 1; j < people.Length; j++)
                {
                    bool triggerUsedName = false;
                    for (int k = 0; k < usedNames.Length; k++)
                    {
                        if (usedNames[k] == j)
                        {
                            triggerUsedName = true;
                            break;
                        }
                    }
                    if (triggerUsedName) continue;
                    if (people[j] == people[i])
                    {
                        people[j].Output();
                        usedNames[counter] = j;
                        counter++;
                        triggerWriteName = true;
                    }
                }
                if (triggerWriteName) people[i].Output();
            }
        }
    }
}


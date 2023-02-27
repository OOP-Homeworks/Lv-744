namespace _26022023_HomeWork_10Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Teacher("Maria", "English Elementary", 343));
            people.Add(new Developer("Iryna", ".Net Core", 456));
            people.Add(new Teacher("Roman", "Early Education", 432));
            people.Add(new Developer("Volodia", "JS", 485));
            people.Add(new Teacher("Petro", "High School", 1212));
            people.Add(new Developer("Konstantyn", "WEB UI", 434));
            people.Add(new Teacher("Marta", "Special Education", 4444));
            people.Add(new Developer("Vira", "Python", 414));
            people.Add(new Teacher("Mykola", "Preschool Teacher", 2121));
            people.Add(new Developer("Nadia", "Java", 4643));

            foreach (var person in people)
            {
                person.Display();
            }

            Console.WriteLine("\nPlease enter a person's name:");
            string personName = Console.ReadLine();
            bool found = false;

            foreach (var person in people)
            {
                if (personName == person.Name)
                {
                    Console.Clear();
                    person.Print();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("There is no person with this name.\n");
            }

            people.Sort();
            string path = @"C:\Users\fedor\source\repos\26022023_HomeWork_10Person\Sorted_names.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("Sorted names:");
                foreach (Person p in people)
                {
                    sw.WriteLine(p.Name);
                }
            }

            Console.WriteLine("\nSorted names:\n");
            foreach (Person p in people)
            {
                p.Print();
            }

            List<Staff> employees = new List<Staff>();
            foreach (Person p in people)
            {
                if (p is Developer || p is Teacher)
                {
                    employees.Add((Staff)p);
                }
            }

            employees.Sort((x, y) => x.Salary.CompareTo(y.Salary));

            Console.WriteLine("\nSorted by salary:\n");
            foreach (Staff employee in employees)
            {
                employee.Print();
            }

            Console.ReadLine();
        }

    }
}
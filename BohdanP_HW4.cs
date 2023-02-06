
namespace HWT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total_persons = 6;
            Person[] persona = new Person[total_persons];

            for (int i=0; i<total_persons; i++)
            {
                persona[i] = new Person();
                
            }
            for (int i = 0; i < total_persons; i++)
            {
                Console.WriteLine(persona[i].GetName);
                int curr_age = persona[i].Age();
                if (curr_age < 16)
                {
                    persona[i].SetLowAgeName();
                }
            }
            for (int i = 0; i < total_persons; i++)
            {
                Console.WriteLine(persona[i].ToString());
            }
            for (int i = 0; i < total_persons; i++)
            {
                for (int j = 0 + i; j < total_persons - 1; j++)
                {
                    if (persona[i] == persona[j + 1])
                    {
                        Console.WriteLine("Match: " + persona[i].ToString() + " with " + persona[j+1].ToString());
                    }
                }
                
            }
        }

        class Person
        {
            private string name;
            private DateTime birthYear;

            internal Person()
            {
                Console.WriteLine("Type name:");
                name = Console.ReadLine();
                Console.WriteLine("Type your birth year:");
                birthYear = new DateTime(Convert.ToInt32(Console.ReadLine()), 1, 1);
            }

            internal Person(string name, int year)
            {

            }

            public string GetName
            {
                get
                {
                    return name;
                }
            }
            public int GetBirthYear
            {
                get
                {
                    return birthYear.Year;
                }
            }

            internal int Age()
            {
                int age =  DateTime.Now.Year - birthYear.Year;
                Console.WriteLine(age);
                return age;
            }

            private string ChangeName()
            {
                name = Console.ReadLine().ToString();
                return name;
            }

            public override string ToString()
            {
                return (name + " " + birthYear.Year).ToString();
            }

            private void Output()
            {
                ToString();
            }

            public static bool operator == (Person a, Person b)
            {
                return a.name.Equals(b.name);
            }
            public static bool operator != (Person a, Person b)
            {
                return !a.name.Equals(b.name);
            }

            internal void SetLowAgeName()
            {
                this.name = "Very young";
            }
        }
    }
}
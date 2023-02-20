using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230215_HW_Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  1. Add two classes Persons and Staff (use the presentation code)
                2. Create two classes Teacher and Developer, derived from Staff. 
                    Add field subject for class Teacher; 
                    Add field level for class Developer; 
                    override method Print for both classes.
                3. In Main, specify a list of Person type and add objects of each type to it. Call for each item in the list method Print ().
                4. Enter the person's name. If this name present in  list - print information about this person
                5. Sort list by name, output to file
                6*. Create a list of Employees and move only workers(teachers+developers) there. Sort them by salary.
                */
            List<Person> persons = new List<Person>();
            persons.Add(new Teacher("Maria", "English Elementary", 343));
            persons.Add(new Developer("Iryna", ".Net Core", 456));
            persons.Add(new Teacher("Roman", "Early Education", 432));
            persons.Add(new Developer("Volodia", "JS", 485));
            persons.Add(new Teacher("Petro", "High School", 1212));
            persons.Add(new Developer("Konstantyn", "WEB UI", 434));
            persons.Add(new Teacher("Marta", "Special Education", 4444));
            persons.Add(new Developer("Vira", "Python", 414));
            persons.Add(new Teacher("Mykola", "Preschool Teacher", 2121));
            persons.Add(new Developer("Nadia", "Java", 4643));

            foreach (var p in persons)
                p.Display();

            Console.WriteLine("\nPlease, enter person's name: ");
            string personName = Console.ReadLine();
            bool t = false;

            foreach (var p in persons)
                if (personName == p.Name)
                {
                    Console.Clear();
                    p.Print(); t = true;
                }

            if (!t) Console.WriteLine("There is no this person\n");

            persons.Sort();
            string path = @"C:\Users\fedor\source\repos\20230215_HomeWork_8\Sorted_names.txt";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("Sorted names:");
                foreach (Person x in persons)
                {
                    sw.WriteLine(x);
                }
            }

            List<Staff> Employees = new List<Staff>();
            foreach (Staff p in persons)
            {
                if (p.GetType() == typeof(Developer))
                    Employees.Add(p);
                if (p.GetType() == typeof(Teacher))
                    Employees.Add(p);
            }

            Console.WriteLine("\nSorting by name:\n");

            foreach (Staff p in Employees)
            {
                p.Print();
            }

            Employees.Sort();
            Console.WriteLine("\nSorting by salary:\n");
            foreach (Staff s in Employees)
                s.Print();

            Console.ReadLine();
        }
    }
}

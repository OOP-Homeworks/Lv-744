using System;
using System.Collections;
using System.Collections.Concurrent;

namespace Lecture4_744;
class Program

{
    static void Main(string[] args)

    {

        Console.WriteLine("\nTask #4");
        showTask4();

        Console.WriteLine("\nTask #5");
        showHomework5();

        Console.ReadKey();

    }

    static void showTask4()
    {

        /// task 1
        /// 

        Car toyota = new Car("Toyota", "Black", 50000.0);
        Car bmw = new Car("BMW", "White", 70000.0);
        Car lexus = new Car("Lexus", "Green", 100000.0);

        toyota.ChangePrice(10.0);
        toyota.Print();

        bmw.ChangePrice(10.0);
        bmw.Print();

        lexus.ChangePrice(10.0);
        lexus.Print();

        Console.Write("\nEnter new color for BMW: ");
        string newColor = Console.ReadLine();
        bmw.Color = newColor;
        Console.WriteLine("\nResult:");
        bmw.Print();

        Console.WriteLine($"\nCompare Toyota&BMW = {toyota==bmw}");

    }

    static void showHomework5()
    {
        /// hw 1
        ///
        Person[] persons = new Person[6];

        persons[0] = new Person("Oleksand", new DateTime(1991, 4, 1));
        persons[1] = new Person("Nikolay", new DateTime(1991, 7, 2));
        persons[2] = new Person("Oleg", new DateTime(1991, 2, 3));
        persons[3] = new Person("Oleksand", new DateTime(1991, 3, 4));
        persons[4] = new Person("Nikolay", new DateTime(1991, 4, 5));
        persons[5] = new Person("Oleksand", new DateTime(1991, 5, 6));

        int countOfArray = persons.Length;

        Console.WriteLine("\nAge:");
        for (int i = 0; i < countOfArray; i++)
        {
            Console.WriteLine($"{i + 1}. {persons[i]} Age={persons[i].Age()}");
        }

        for (int i = 0; i < 5; i++)
        {
            if (persons[i].Age() < 16)
            {
                persons[i].ChangeName("Very Young");
            }
        }

        Console.WriteLine("\nInfo about students:");
        for (int i = 0; i < countOfArray; i++)
        {
            Console.WriteLine($"{persons[i].Output()}");
        }


        /// sort "group by"
        /// 
        Console.WriteLine("\nSort by 'group by' ");
        var equalNames = from person in persons
                         group person by person.Name;
        foreach (var equalName in equalNames)
        {
            Console.WriteLine(equalName.Key);

            int i = 0;

            foreach (var person in equalName)
            {
                //Console.WriteLine(person.Name);
                i++;
            }
            Console.WriteLine(i);
        }

        /// sort by cycle & ==
        /// 
        Console.WriteLine("\nSort by cycle & == ");
        string[] arrayEqualNames = new string[countOfArray];
        int countEqalArray = 0;
        for (int i = 0; i < countOfArray; i++)
        {
            arrayEqualNames[countEqalArray] = persons[i].Name;
            countEqalArray++;
        }
        ArrayList dup = new ArrayList();
        for (int i = 0; i < arrayEqualNames.Length; i++)
        {
            for (int j = i + 1; j < arrayEqualNames.Length; j++)
            {
                if (arrayEqualNames[i].Equals(arrayEqualNames[j]))
                {
                    if (!dup.Contains(arrayEqualNames[i]))
                    {
                        dup.Add(arrayEqualNames[i]);
                    }
                }
            }
        }
        Console.WriteLine("The numbers which duplicates are");
        for(int i = 0; i < dup.Count; i++)
        {
            Console.Write(dup[i] + " ");
        }

    }

}


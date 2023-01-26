using System;

namespace lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            At1();
            At2();
            Console.ReadKey();
        }

        //Task 2
        struct Student
        {
            public string lastName;
            public int groupNumber;
        }
        static void At2()
        {
            Console.Write("Enter the general number of students: ");
            int studentsNumber = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[studentsNumber];
            for (int i = 0; i < studentsNumber; i++)
            {
                Console.Write("Enter the last name of student: ");
                students[i].lastName = Console.ReadLine();
                Console.Write("Enter the group the student belongs to: ");
                students[i].groupNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter the number of group you want to see: ");
            int outputGroupNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first letter of student's last name: ");
            char letter  = Convert.ToChar(Console.Read());
            Console.ReadLine();
            foreach (Student i in students)
            {
                if (i.groupNumber == outputGroupNumber)
                {
                    if (i.lastName[0] == letter) Console.WriteLine(i.lastName);
                }
            }  
        }


        //Task 1
        static void At1()
        {
            Console.WriteLine("Choose what to eat(Fish/Mouse/Kitekat). Press 1/2/3/4");
            char digit = Convert.ToChar(Console.Read());
            Console.ReadLine();
            Cat cat = new Cat();
            switch (digit)
            {
                case '1':
                    cat.EatSomething(Food.Fish);
                    break;
                case '2':
                    cat.EatSomething(Food.Mouse);
                    break;
                case '3':
                    cat.EatSomething(Food.Kitekat);
                    break;
                case '4':
                    cat.EatSomething(Food.Chocolate);
                    break;
                default:
                    Console.WriteLine("You entered incorrect choice");
                    break;
            }
            cat.DisplayFullness();
        }
    }

    enum Food { Fish = 15, Mouse = 10, Kitekat=20, Chocolate=-10 };
    class Cat
    {
        public int fullnessLevel = 50;
        public void EatSomething(Food food)
        {
            fullnessLevel += (int)food;
            Console.WriteLine(  (int)food > 0 ?
                                $"Such a delicious {food}!\n" +
                                $"The level of fullness was increased by {(int)food} points" :

                                $"Oops. Cats don't eat {food}\n" +
                                $"The level of fullness was decreased by {-(int)food} points"
            );
        }
        public void DisplayFullness()
        {
            Console.WriteLine($"The level of fullness = {fullnessLevel}");
        }
    }
}
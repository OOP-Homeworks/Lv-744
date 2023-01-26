using System;

class Program1
{
    static void Main(string[] args)
    {
        //CatFeeding();
        Student[] arr = CreatingStudentsArray();
        OutputOfStudents(arr);
    }
    static void CatFeeding()
    {
        Cat myCat = new Cat();
        do
        {

            Console.WriteLine($"Fulness level of your cat is {myCat.FulnessLevel}");
            Console.WriteLine("What do you want to give to your cat? (Fish, Mouse, Meat)");
            string catsFood = Console.ReadLine();
            switch (catsFood)
            {
                case "Fish":
                    myCat.EatSomething(Food.Fish);
                    break;
                case "Mouse":
                    myCat.EatSomething(Food.Mouse);
                    break;
                case "Meat":
                    myCat.EatSomething(Food.Meat);
                    break;
            }
            Console.WriteLine(myCat.FulnessLevel);
        }
        while (myCat.FulnessLevel < 100);
        Console.WriteLine("Your cat is satisfied");
    }
    static Student[] CreatingStudentsArray()
    {
        Console.WriteLine("Enter number of students you want to add to array: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        Student[] arr = new Student[numberOfStudents];
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine("Enter last name of the student: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter number of student's group: ");
            int numberOfGroup = int.Parse(Console.ReadLine());
            arr[i].LastName = lastName;
            arr[i].NumberOfGroup = numberOfGroup;  
        }
        return arr;
    }
    static void OutputOfStudents(Student[] arr)
    {
        Student[] temparr = new Student[arr.Length];
        int counter = 0;
        Console.WriteLine("Enter starting letter of last name: ");
        char letter = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter number of group: ");
        int group = int.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].NumberOfGroup == group && arr[i].LastName[0] == letter)
            {
                temparr[counter] = arr[i];
                counter++;
            }
        }
        for(int i = 0; i < counter; i++)
        {
            Console.WriteLine($"Last name is {temparr[i].LastName}, number of group is {temparr[i].NumberOfGroup}.");
        }
    }
}

class Cat
{
    public int FulnessLevel { get; private set; }
    public void EatSomething(Food food)
    {
        FulnessLevel += (int)food;
    }
}
enum Food
{
    Fish = 10,
    Mouse = 30,
    Meat = 50
}
struct Student
{
    public string LastName;
    public int NumberOfGroup;
}
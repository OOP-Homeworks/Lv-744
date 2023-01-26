using System;

class Program
{
    static void Main(string[] args)
    {
        //Task1();
        //Task2();
        //Task3();
        //Task4();
    }
    static void Task1()
    {
        Console.WriteLine("Enter first number: ");
        float first = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        float second = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        float third = float.Parse(Console.ReadLine());
        Console.WriteLine((first >= -5 && first <= 5) && (second >= -5 && second <= 5) && (third >= -5 && third <= 5) ?
                                                                                                                    "All the numbers are between -5 and 5." :
                                                                                                                    "There are number out of range.");
    }
    static void Task2()
    {
        Console.WriteLine("Enter first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        int third = int.Parse(Console.ReadLine());
        int max = Math.Max(first, Math.Max(second, third));
        int min = Math.Min(first, Math.Min(second, third));
        Console.WriteLine($"Highest number is {max}");
        Console.WriteLine($"Lowest number is {min}");
    }
    enum HTTPError 
    {
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404
    }
    static void Task3()
    {
        Console.WriteLine("Enter number of error: ");
        int error = int.Parse(Console.ReadLine());
        Console.WriteLine((HTTPError)error);
    }
    public struct Dog
    {
        public string Name;
        public string Mark;
        public float Age;

        public override string ToString()
        {
            return String.Format("Your dog: name is {0}, mark is {1} and it is {2} years old.", Name, Mark, Age);
        }
    }
    static void Task4()
    {
        Dog myDog;
        Console.WriteLine("Enter name of your dog: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter mark of your dog: ");
        string mark = Console.ReadLine();
        Console.WriteLine("Enter name of your dog: ");
        float age = float.Parse(Console.ReadLine());

        myDog.Name = name;
        myDog.Mark = mark;
        myDog.Age = age;

        Console.WriteLine(myDog);
    }
}

using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter length of the side of the square: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine($"Area of the square is {a * a}");
        Console.WriteLine($"Perimetr of the square is {a * 4}");

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"How old are you, {name}?");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your name is {name}, you are {age}.");

        Console.WriteLine("Enter radius of the circle: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine($"Length of the circle is {2 * Math.PI * r}");
        Console.WriteLine($"Length of the circle is {Math.PI * r * r}");
        Console.WriteLine($"Length of the circle is {4 / 3.0 * Math.PI * Math.Pow(r, 3)}");
    }

}
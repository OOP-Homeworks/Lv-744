using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Task1();
        //Task2();
        Task3();
    }
    static void Task1()
    {
        int counter = 0;
        Console.WriteLine("Enter you sentence: ");
        string sentence = Console.ReadLine();
        foreach (char symbol in sentence)
        {
            if (symbol == 'a' || symbol == 'o' || symbol == 'i' || symbol == 'e') counter++;
        }
        Console.WriteLine($"There are {counter} needed letters.");
    }
    static void Task2()
    {
        int[] daysOfMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.WriteLine("Enter number of month: ");
        int month = int.Parse(Console.ReadLine());
        Console.WriteLine(month > 0 && month <= 12 ? $"This month has {daysOfMonths[month - 1]} days." : "This month doesn't exist.");
    }
    static void Task3()
    {
        int result = 1;
        bool firstTaskCase = true;
        int numberOfNumbers = 10;
        int[] numbers = new int[numberOfNumbers];
        for(int i = 0; i < numberOfNumbers; i++)
        {
            Console.WriteLine($"Enter your {i + 1} number.");
            numbers[i] = int.Parse(Console.ReadLine());
            if(i < 5 && numbers[i] < 0) firstTaskCase = false;
        }
        if (firstTaskCase) for (int i = 0; i < numberOfNumbers / 2; i++) result += numbers[i];
        else for (int i = numberOfNumbers/2; i < numberOfNumbers; i++) result *= numbers[i];

        Console.WriteLine(firstTaskCase ? $"The sum is {result - 1}" : $"{result}");
    }
}
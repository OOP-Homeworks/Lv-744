using Lecture2_744;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

internal class Program
{
    enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted }
    enum HTTPErrors { BadRequest=400, Unauthorized, PaymentRequired, Forbidden, NotFound}
   
    struct RGB
    { 
        public byte red;
        public byte green;
        public byte blue;

        public RGB(byte red, byte green, byte blue)
        { 
            this.red = red;
            this.green = green;
            this.blue = blue;      
        }

        public override string ToString()
        {
            return string.Format($"R={red} G={green} B={blue}");
        }

    }

    struct Dog
    { 
        public string name;
        public string mark;
        public int age;

        public Dog(string name, string mark, int age)
        {
            this.name = name;
            this.mark = mark;
            this.age = age;
        }

        public override string ToString()
        {
            return string.Format($"name={name} mark={mark} age={age}");
        }

    }

    struct Student
    {
        public string lastName;
        public int groupNumber;

        public Student(string lastName, int groupNumber)
        {
            this.lastName = lastName;
            this.groupNumber = groupNumber;
        }

        public override string ToString()
        {
            return string.Format($"lastName={lastName} groupNumber={groupNumber}");
        }
    }

    private static void Main(string[] args)
    {

        Console.WriteLine("Tasks #2:");
        showTask2();

        Console.WriteLine("\nHomework #2:");
        showHomework2();

        Console.WriteLine("\nAdditional tasks #2:");
        showAdditionalTask2();

        Console.ReadKey();

    }

    static void showTask2()

    {

        /// T A S K 2
        /// 1.1 
        /// 

        Console.Write("\nEnter number of month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(
            ((day > 31) || (day == 0) || (month > 12) || (month == 0))
            ? "Error! Days must be no more than 31 and months no more than 12!" :
            ((month == 2) && (day > 29))
                ? "Error! In Febryary must be no more than 29 days!" :
                ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
                    ? "Error! In 4, 6, 9, 11 months must be no more than 30 days!" :
                    ((month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) && day > 31)
                        ? "Error! In 1, 3, 5, 7, 8, 10, 12 months must be no more than 31 days!" :
                        "All is correct!");

        /// 1.2 
        ///
         
        Console.Write("\nEnter double number: ");
        double k = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
        int k_int = Convert.ToInt32(k * 100);
        char[] k_array = Convert.ToString(k * 100).ToCharArray();
        int position = 0;
        
        for (int i = 0; i < k_array.Length; i++)
        {
            position = i;
            if (k_array[i] == ',' || k_array[i] == '.')
            {
                break;
            }      
        }

        if (!(position == 0))
        {
            int sum_1 = Convert.ToInt32(k_array[position-2].ToString());
            int sum_2 = Convert.ToInt32(k_array[position-1].ToString());
            Console.WriteLine($"{sum_1} + {sum_2} = {sum_1 + sum_2}");
        }
        else
        {
            Console.WriteLine("Wrong number...");
        }

        /// 1.3 
        ///

        Console.Write("\nEnter the time of day (hour):");
        int timeOfDay = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(
            timeOfDay >= 6 && timeOfDay <= 12
            ? "Good morning!" :
                timeOfDay >= 12 && timeOfDay <= 18
                ? "Good afternoon!" :
                    timeOfDay >= 18 && timeOfDay <= 22
                    ? "Good evening!" : "Good night!");

        /// 1.4 
        ///

        TestCaseStatus myEnum = TestCaseStatus.Pass;
        int TestCaseStatus_Number = (int) myEnum;
        Console.WriteLine($"\nYour enum is {myEnum} with number {TestCaseStatus_Number}");

        /// 1.5 
        ///
        RGB myRGB_White = new RGB(255,255,255);
        Console.WriteLine("\nWHITE= "+myRGB_White);
        RGB myRGB_Black = new RGB(0, 0, 0);
        Console.WriteLine("BLACK= " + myRGB_Black);

    }

    static void showHomework2()

    {

        /// 1.1 
        ///

        Console.Write("\nEnter float number:");
        //float number_task1 = Convert.ToDouble(Console.ReadLine());
        float number_task1 = float.Parse(Console.ReadLine().Replace(",","."), CultureInfo.InvariantCulture.NumberFormat);
        int a_min = -5;
        int a_max = 5;
        if (number_task1 >= a_min && number_task1 <= a_max)
        {
            Console.WriteLine($"Number {number_task1} is in the range :)");
        }
        else 
        {
            Console.WriteLine($"Number {number_task1} is not in the range :(");
        }

        /// 1.2 
        ///

        Console.WriteLine("\nMax or Min?");
        int countValuesInt = 3;
        int[] arrayValuesInt = new int[countValuesInt];
        for (int i = 0; i < countValuesInt; i++)
        {
            Console.WriteLine("Enter int number:");
            arrayValuesInt[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Please wait...");
        Thread.Sleep(1000);
        
        Console.WriteLine($"Max={arrayValuesInt.Max()} Min={arrayValuesInt.Min()}");

        /// 1.3
        ///

        Console.WriteLine("\nEnter HTTP error code:");
        int httpErrorNumber = Convert.ToInt32(Console.ReadLine());

        if (httpErrorNumber >= 400 && httpErrorNumber <= 404)
        {
            Console.WriteLine($"Error name = {GetMyHTTPErrorName(httpErrorNumber)}");
        }
        else
        {
            Console.WriteLine("Unknown error!");
        }

        /// 1.4
        /// 
        Console.WriteLine("\nEnter the dog's name:");
        string dogName = Console.ReadLine();

        Console.WriteLine("Enter the dog's mark:");
        string dogMark = Console.ReadLine();

        Console.WriteLine("Enter the dog's age:");
        int dogAge = Convert.ToInt32(Console.ReadLine());

        Dog myDog = new Dog(dogName, dogMark, dogAge);
        Console.WriteLine("Info about dog: "+myDog);

    }

    static void showAdditionalTask2()
    {

        /// 1
        ///
        
        Cat barsic = new Cat("Barsic");
        barsic.FullnessLevel = Food.Mouse;
        Console.WriteLine("\nCat eat = " + Food.Mouse);
        Console.WriteLine(barsic);

        Console.WriteLine("\nCat eat = " + Food.Fish);
        barsic.FullnessLevel = Food.Fish;
        Console.WriteLine(barsic);

        /// 2
        /// 

        Console.WriteLine("\nStudents!");
        int countStudents = 4;
        Student[] arrayStudent = new Student[countStudents];
        for (int i = 0; i < countStudents; i++)
        {
            Console.Write($"Enter #{i} student's name: ");
            string fullName = Console.ReadLine();
            Console.Write($"Enter #{i} student's group number: ");
            int groupNumber = Convert.ToInt32(Console.ReadLine());
            Student student = new Student(fullName, groupNumber);
            arrayStudent[i] = student;
        }

        Console.Write($"\nEnter first letter of student's name: ");
        string findFirstLetter = Console.ReadLine();
        Console.Write($"Enter number of student's group number: ");
        int findGroupNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < countStudents; i++)
        {
            if (findFirstLetter[0] == arrayStudent[i].lastName[0]
                     && findGroupNumber == arrayStudent[i].groupNumber)
            {
                Console.WriteLine("\nFind:");
                Console.WriteLine(arrayStudent[i]);
            }
        }

    }

    static string GetMyHTTPErrorName(int HTTPIndex)
    {
        HTTPErrors ErrorName = (HTTPErrors)HTTPIndex;
        return ErrorName.ToString();
    }

}

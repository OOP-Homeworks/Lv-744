

internal class Program
{
    private static void Main(string[] args)
    {
        showTask1();
        showHomework1();
    }

    static void showTask1()
    { 
        /// T A S K - 1

        ///=======================================
        /// 1.1
        /// 
        Console.WriteLine("\n1.1 Int type");

        Console.Write("Enter a=");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter b=");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        Console.WriteLine($"{a} / {b} = {a/b}");

        ///=======================================
        /// 1.2
        /// 
        Console.WriteLine("\n1.2 String type");

        Console.WriteLine("How are you?");
        string answer = Console.ReadLine();
        Console.WriteLine("You are {0}", answer);

        ///=======================================
        /// 1.3
        /// 
        Console.WriteLine("\n1.3 Char type");
        Console.WriteLine("Please enter 3 char:");

        char a_char = char.Parse(Console.ReadLine());
        char b_char = char.Parse(Console.ReadLine());
        char c_char = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("You enter (first {0}), (second {1}), (3 {2})", a_char, b_char, c_char);

        Console.WriteLine("And last one:");

        if (char.TryParse(Console.ReadLine(), out char result))
        {
            Console.WriteLine("It's char");
        }
        else
        {
            Console.WriteLine("It's don't char");
        }

        ///=======================================
        /// 1.4
        ///
        Console.WriteLine("\n1.4 Bool type");

        Console.WriteLine("Please enter 2 numbers:");
        int k = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());
        bool isNumbersPositive = false;

        if (k > 0 && l > 0)
        {
            isNumbersPositive = true;
        }
        Console.WriteLine("Numbers are both positive = {0}", isNumbersPositive);

    }

    static void showHomework1()
    {

        /// H O M E W O R K - 1

        ///=======================================
        /// 1.1
        ///
        Console.WriteLine("\n1.1 Enter side of the square:");

        double side = Convert.ToDouble(Console.ReadLine());
        double s1 = Math.Pow(side,2);
        Console.WriteLine($"Area = {s1:N2}");
        double p1 = 4 * side;
        Console.WriteLine($"Perimeter = {p1:N2}");

        ///=======================================
        /// 1.2
        ///
        Console.WriteLine("\n1.2 What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"How old are you, {name}?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Your age is {age}");

        ///=======================================
        /// 1.3
        ///
        Console.WriteLine("\n1.3 Enter radius of a circle:");
        double radius = Convert.ToDouble(Console.ReadLine());


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


        {
            //Task1
            float num;
            for (int i = 0; i < COUNT_OF_CHACKING_RANGE; i++) {
                Console.Write("Enter float numer : ");
                while (!float.TryParse(Console.ReadLine().Replace(',', '.').Replace(".0",""), NumberStyles.Float ,
                    CultureInfo.InvariantCulture, out num)){

                    Console.Write("Enter correct float numer : ");
                }
                RangeChecker(num, MIN_OF_CHACKING_RANGE, MAX_OF_CHACKING_RANGE);
            }
            Console.Write("\n\n\n");
            //Task2
            int[] inrArr = new int[COUNT_OF_MIN_MAX_CHACKING];
            for (int i = 0; i < COUNT_OF_MIN_MAX_CHACKING; i++) {
                Console.Write("Enter int numer : ");
                while (!int.TryParse(Console.ReadLine(), out inrArr[i]))
                {
                    Console.Write("Enter correct float numer : ");
                }
            }
            MinMaxChecker(inrArr);
            Console.Write("\n\n\n");
            //Task3
            int erorNum;
            Console.Write("Enter error numer : ");
            while (!int.TryParse(Console.ReadLine(), out erorNum))
            {
                Console.Write("Enter correct int numer : ");
            }
            HttpErrorChecker(erorNum);
            Console.Write("\n\n\n");
            //Task4
            string name;
            int mark;
            int age;
            Console.Write("Enter dog's name : ");
            name = Console.ReadLine();
            Console.Write("Enter dog's mark : ");
            while (!int.TryParse(Console.ReadLine(), out mark))
            {
                Console.Write("Enter correct dog's mark : ");
            }
            Console.Write("Enter dog's age : ");
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Enter correct dog's age : ");
            }
            Dog dog1 = new Dog(name, mark, age);
            Console.WriteLine("{0}",dog1.ToString());
            Console.ReadLine();
        }
        //Task1_Func
        static void RangeChecker(float num, float min, float max)
        {
            if (num >= min && num <= max)
            {
                Console.WriteLine("Nunber {0} is in range [{1} ; {2}]", num, min, max);
            }
            else {
                Console.WriteLine("Nunber {0} isn't in range [{1} ; {2}]", num, min, max);
            }
        }
        //Task2_Func
        static void MinMaxChecker(int[] inrArr)
        {
            int min = inrArr[0];
            int max = inrArr[0];
            for (int i = 0; i < inrArr.Length; i++) {
                if (inrArr[i] < min)
                {

                    min = inrArr[i];
                }
                else if (inrArr[i] > max) {
                    max = inrArr[i];

                    Console.Clear();

            Console.WriteLine("Min number : {0} , Max number {1}", min, max);
        }
        //Task3_Func
        static void HttpErrorChecker(int erorNum)
        {
            if (erorNum >= 100 && erorNum <= 199)
            {
                Console.WriteLine("{0} error", HttpErors.Informational);
            }
            else if (erorNum >= 200 && erorNum <= 299)
            {
                Console.WriteLine("{0} error", HttpErors.Successful);
            }
            else if (erorNum >= 300 && erorNum <= 399)
            {
                Console.WriteLine("{0} error", HttpErors.Redirect);
            }
            else if (erorNum >= 400 && erorNum <= 499)
            {
                Console.WriteLine("{0} error", HttpErors.Client);
            }
            else if (erorNum >= 500 && erorNum <= 599)
            {
                Console.WriteLine("{0} error", HttpErors.Server);
            }
            else {
                Console.WriteLine("No such error");
            }


        double l3 = 2 * Math.PI * radius;
        Console.WriteLine($"Lenght = {l3:N2}");

        double s3 = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine($"Area = {s3:N2}");

        double v3 = (4 / 3) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Volume = {v3:N2}");


    }

}


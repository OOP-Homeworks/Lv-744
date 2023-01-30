
namespace HW_3_2023
{
    class Program
    {

        static void Main(string[] args)
        {
            //Task_1

            Console.Write("Enter your string : ");
            string str = Console.ReadLine();
            int countA = 0,
                countO = 0,
                countI = 0,
                countE = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a')
                    countA++;
                if (str[i] == 'o')
                    countO++;
                if (str[i] == 'i')
                    countI++;
                if (str[i] == 'e')
                    countE++;
            }
            Console.WriteLine(" You have \n A - {0}  \n O - {1} \n I - {2}  \n E - {3}", countA, countO, countI, countE);

            //Task_2

            Console.Write("\nEnter number of month : ");

            int numberOfMonth = int.Parse(Console.ReadLine());

            switch (numberOfMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 2:
                    Console.Write("Enter a year of this month : ");
                    int year = int.Parse(Console.ReadLine());
                    if (DateTime.IsLeapYear(year))
                        Console.Write("Year is leap, February have 29 days");
                    else
                        Console.Write("Year does not leap, February have 28 days");
                    break;
                default:
                    Console.Write("Month does not exist !");
                    break;

            }

            //Task_3


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


            int[] arr = new int[10] { -10, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            int sum = 0;
            int mult = 1;
            int counter = 0;
            int[] arrMult = arr[5..];
            bool isPositive = false;

            for (int i = 0; i < arr[5]; i++)
            {
                if (arr[i] > 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            if (counter == 5)
                isPositive = true;
            if (isPositive == true)
            {
                {
                    for (int j = 0; j <= 4; j++)
                        sum += arr[j];
                }
                Console.WriteLine("\nSum of first five integers of array is : {0}", sum);
            }
            else
            {
                for (int k = 0; k < arrMult.Length; k++)
                {
                    mult *= arrMult[k];
                }
                Console.WriteLine("\nMultiplie of last 5 integers of array is : {0}", mult);
            }
            Console.Write("Array  : ");
            foreach (var item in arr)
            {
                Console.Write(" {0}",item);
            }
        }
    }


}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20230123_HomeWork_2
{
    public struct Dog
    {
        public string name;
        public string mark;
        public int age;
    }

    public enum HTTPError
    {
        BadRequest = 400,
        Unauthorized,
        PaymentRequired,
        Forbidden,
        NotFound,
        MethodNotAllowed,

        // 500 Server Error
        InternalServerError = 500,
        NotImplemented,
        BadGateway,
        ServiceUnavailable,
        GatewayTimeout,
        HTTPVersionNotSupported,
        VariantAlsoNegotiates,
        InsufficientStorage
    }

    public class Program
    {
        const int MIN_RANGE_NUMBER = -5;
        const int MAX_RANGE_NUMBER = 5;
        static void Main(string[] args)
        {
            // 1. Read 3 float numbers and check if they are all in the range[-5.5].

            Console.Write("Enter float number:  ");
            float number1 = float.Parse(Console.ReadLine());
            Console.Write("Enter next float number:  ");
            float number2 = float.Parse(Console.ReadLine());
            Console.Write("Enter new float number:  ");
            float number3 = float.Parse(Console.ReadLine());
            Console.Clear();

            if (number1 >= MIN_RANGE_NUMBER && number1 <= MAX_RANGE_NUMBER)
            {
                Console.WriteLine("Number: {0} in the range [{1}.{2}]", number1, MIN_RANGE_NUMBER, MAX_RANGE_NUMBER);
            }
            else
            {
                Console.WriteLine("Number: {0} out of range [{1}.{2}]", number1, MIN_RANGE_NUMBER, MAX_RANGE_NUMBER);
            }

            if (number2 >= MIN_RANGE_NUMBER && number2 <= MAX_RANGE_NUMBER)
            {
                Console.WriteLine("Number: {0} in the range [{1}.{2}]", number2, MIN_RANGE_NUMBER, MAX_RANGE_NUMBER);
            }
            else
            {
                Console.WriteLine("Number: {0} out of range [{1}.{2}]", number2, MIN_RANGE_NUMBER, MAX_RANGE_NUMBER);
            }

            if (number3 >= MIN_RANGE_NUMBER && number3 <= MAX_RANGE_NUMBER)
            {
                Console.WriteLine("Number: {0} in the range [{1}.{2}]", number3, MIN_RANGE_NUMBER, MAX_RANGE_NUMBER);
            }
            else
            {
                Console.WriteLine("Number: {0} out of range [{1}.{2}]", number3, MIN_RANGE_NUMBER, MAX_RANGE_NUMBER);
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 2. Read 3 integer numbers and output max and min of them.

            int[] myArray = new int[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter integer number:  ");
                myArray[i] = int.Parse(Console.ReadLine());

            }

            Console.Clear();

            int maxValue = myArray.Max();
            int maxValue2 = myArray.Min();

            foreach (int i in myArray)
            {
                if (i > maxValue2 && i < maxValue)
                {
                    maxValue2 = i;
                }
            }

            int minValue = myArray.Min();
            int minValue2 = myArray.Max();

            foreach (int i in myArray)
            {
                if (i < minValue2 && i > minValue)
                {
                    minValue2 = i;
                }
            }

            Console.WriteLine("Your enter Integer number: [{0}]", string.Join(", ", myArray));
            Console.WriteLine("\nMax number: {0}, next max: {1}, min number: {2}, next min: {3}", maxValue, maxValue2, minValue, minValue2);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            // 3. Read number of HTTP Error(400, 401, 402, ...) and write the name of this error (Declare enum HTTPError)

            HTTPError error1Status = HTTPError.NotFound;
            Console.WriteLine($"Integral value of {error1Status} is {(int)error1Status}");

            var error2Status = (HTTPError)505;
            Console.WriteLine(error2Status);

            var error3Status = (HTTPError)401;
            Console.WriteLine(error3Status);

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();

            /* 4. Declare struct Dog with fields name, mark, age.
            Declare object myDog of Dog type and read values for it.
            Output information on the console. (Override method ToString in struct) */

            Dog myDog;
            myDog.name = "Hatiko";
            myDog.mark = "Akita";
            myDog.age = 5;

            Console.WriteLine("Name my dog: {0}\n\tMark: {1}\n\tAge: {2}", myDog.name, myDog.mark, myDog.age);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}

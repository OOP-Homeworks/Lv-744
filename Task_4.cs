using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /* Define class Car with fields name, color, price and const field CompanyName          	
     * Create two constructors - default and with parameters.                                         	
     * Create a property to access the color field.                                           			
     * Define methods: Input () - to enter data about cars from the console,				
     * Print () - to output data about cars on the console					
     * ChangePrice (double x) - to change the price by x%
        Enter data about 3 cars.
        Decrease car price by 10%, display info about the car on the console.
        Enter a new color and “repaint” the car from the color white in the defined color
        Overload operator == for the class Car (cars - equal if the name and price are equal)
        Override method ToString()  in the class Car, which returns a line with data about cars */

    class Car
    {
        private string name = "No Name";
        private string color = "White";
        private double price = 15432.55;
        const string CompanyName = "WV";

        public static bool operator == (Car a, Car b)
        {
            return a.name == b.name && a.price == b.price;
        }

        public static bool operator !=(Car a, Car b)
        {
            return !(a == b);
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (value == "Black" || value == "Yellow" || value == "Red")
                    color = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter: Black, Yellow or Red color");
                    Console.ResetColor();
                }
            }
        }

        public double ChangePrice
        {
            get { return price; }
            set
            {
                price = price - price / 100 * value;
            }
        }

        public Car()
        {

        }

        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{CompanyName} {name}\nColor: {color}\nPrice: {price}$";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Car A4 = new Car();

            Car B5 = new Car("Passat", "Black", 32000.10);

            Car ID_4 = new Car("ID 4", "Yellow", 45000.55);

            A4.Color = "Yellow";

            Console.Write("Enter color for A4 (Red, Black or Yellow): ");
            A4.Color = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("1. {0}\n\n2. {1}\n\n3. {2}\n\n", A4.ToString(), B5.ToString(), ID_4.ToString());
            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();
            Console.Clear();

            B5.ChangePrice = 10;

            Console.WriteLine("1. {0}\n\n2. {1}\n\n3. {2}\n\n", A4.ToString(), B5.ToString(), ID_4.ToString());
            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();
            Console.Clear();

            Car a = new Car();
            Car b = new Car();
            a.Color = "Black";
            // b.ChangePrice = 50;

            if (a == b) Console.WriteLine("The same names and price:\n");
            else Console.WriteLine("Not the same names and price:\n");

            Console.WriteLine("1. {0}\n\n2. {1}", a.ToString(), b.ToString());
            Console.Write("\nPress any key to contiune...");
            Console.ReadKey();
        }
    }
}
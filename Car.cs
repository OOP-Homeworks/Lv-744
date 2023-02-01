using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe
{
    internal class Car
    {
        private static string name;
        private static string color;
        private static decimal price;
        const string CompanyName = "Samsung";

        public Car(string color)
        {
            Car.color = color;
            price = 200;
            name = CompanyName;


        }

        public string Color
        {
            get { return color; }
            set
            {
                if (color == "Red")
                    color = value;
                else
                {
                    
                }
            }
        }
        public string Name
        {
            get { return name; }

        }
        public decimal Price
        {
            get { return price; }
        }


        public void Input()
        {
            Console.WriteLine("Enter data about cars: ");
            Console.Write("Name:");
            name = Console.ReadLine();
            Console.Write("Color: ");
            color = Console.ReadLine();
            Console.Write("Price: ");
            price = int.Parse(Console.ReadLine());



        }
        public void Print()
        {
            Console.WriteLine();
            Input();
            Console.WriteLine();

        }
        public override string ToString()
        {
            Console.WriteLine();
            return ($"The name: [{name}]\nColor is: [{color}] \nPrice: [{price}]");
        }
        public double ChangePrice()
        {
            double percent = (double)price - (double)(price / 10);
            return percent;

        }

        public static bool operator ==(Car car1, Car car2)
        {
            return car1.Name == car2.Name && car1.Price == car2.Price;
        }

        public static bool operator !=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }











        public Car()
        {

        }
    }
}

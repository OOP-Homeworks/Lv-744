using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2023
{
    class Car
    {
        public string name;
        public string color;
        public double price;
        public const string CompanyName = "Honda";


        public Car() { }
        public Car(string name, string color, double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public void Input()
        {
            Console.Write("Enter car model : ");
            name = Console.ReadLine();
            Console.Write("Enter color : ");
            color = Console.ReadLine();
            Console.Write("Enter price : ");
            price = Convert.ToDouble(Console.ReadLine());
            Car car = new Car(name, color, price);
            car.ToString();
        }
        public void Output()
        {
            Console.WriteLine($"{CompanyName}  {name} in {color} color cost {price}");
        }
        public double ChangePrice(double percent)
        {
            price -= price * percent / 100;
            return price;
        }
        public string Repaint(Car car, string newColor)
        {
            if (car.color == "White")
            {
                car.color = newColor;
            }
            else
            {
                newColor = car.color;
            }
            return newColor;
        }
        public static bool operator ==(Car first, Car second)
        {
            return first.name == second.name && first.price == second.price;
        }
        public static bool operator !=(Car first, Car second)
        {
            return first.name != second.name && first.price != second.price;
        }
        public override string ToString()
        {
            return "Car" + CompanyName + name + "color" + color + "price" + price;
        }


    }
}

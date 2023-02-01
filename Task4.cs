using System;
using System.Globalization;
using System.Xml.Schema;
using System.Globalization;

namespace Task_4
{
    class Car
    {
        public enum Colors
        {
            Red, Blue, Green, Yellow
        }
        //Fields

        string name;
        Colors color;
        double price;
        const string CompanyName = "Taranko Industries";
        


        //Properties

        public Colors Color
        {
            get { return color; }
            set { color = value; }
        }

        //Constructors

        public Car() {
            this.name = "";
            this.color = Colors.Red;
            this.price = 0;
            
        }
        public Car(string name , Colors color , double price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
            
        }

        //Methods

        public void Input() {
            Console.Write("Enter car naem :");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter car price :");
            while (!Double.TryParse(Console.ReadLine().Replace(',', '.').Replace(".0", ""), NumberStyles.Float,
                    CultureInfo.InvariantCulture, out this.price)) {
                Console.WriteLine("Enter correct car price :");
            }
            Console.WriteLine("Enter car color (Red, Blue, Green, Yellow) :");
            string col;
            col = Console.ReadLine();
            while (col != "Red" || col != "Blue" || col != "Green" || col != "Yellow") {
                Console.WriteLine("Enter correct car color (Red, Blue, Green, Yellow) :");
                col = Console.ReadLine();
            }
            switch (col) {
                case "Red":
                    this.color = Colors.Red;
                    break;
                case "Blue":
                    this.color = Colors.Blue;
                    break;
                case "Green":
                    this.color = Colors.Green;
                    break;
                case "Yellow":
                    this.color = Colors.Yellow;
                    break;

            }
        }
        public void Print() {
            Console.WriteLine("Car name : {0} , price : {1:N}$ , color : {2} , company : {3}", this.name, this.price, this.color, CompanyName );
        }
        public void ChangePrice(double x) {
            this.price += (this.price * x) / 100;
        }

        //Operators 
        public static bool operator ==(Car c1, Car c2) {
            if (c1.name == c2.name && c1.price == c2.price) {
                return true;
            }
            return false;
        }
        public static bool operator !=(Car c1, Car c2)
        {
            if (c1.name != c2.name || c1.price != c2.price)
            {
                return true;
            }
            return false;
        }

        //Overload methods

        public override string ToString()
        {
            return $"Car name : {this.name} , price : {this.price:N}$ , color : {this.color} , company : {CompanyName}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("BMW" ,Car.Colors.Red , 1500.2);
            Car c2 = new Car("Honda", Car.Colors.Blue, 3600.14);
            Car c3 = new Car("Renault", Car.Colors.Yellow, 23100.324);
            c1.Print();
            c2.Print();
            c3.Print();
            Console.WriteLine("\n\n");
            c1.ChangePrice(10);
            c1.Print();
            c2.Color = Car.Colors.Green;
            c2.Print();
            Console.ReadLine();
        }
    }
}

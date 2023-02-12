using System;
namespace Lecture4_744
{
	public class Car
	{

		private string name;
		private string color;
		private double price;
		private const string COMPANY_NAME = "";

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

        public Car()
		{
		}

		public Car(string _name, string _color, double _price)
		{
			name = _name;
			color = _color;
			price = _price;
		}

		public void Input()
		{
			Console.Write("Enter name:");
			name = Console.ReadLine();
			Console.Write("Enter color:");
			color = Console.ReadLine();
			Console.Write("Enter price:");
			price = Convert.ToDouble(Console.ReadLine());
		}

		public void Print()
		{
			Console.WriteLine($"\nName: {name}");
			Console.WriteLine($"Color: {color}");
			Console.WriteLine($"Price: {price}");
		}

		public void ChangePrice(double x)
		{
			price = price + (price / 100) * x;
		}

		public static bool operator == (Car first, Car second)
		{
			return first.name == second.name && first.price == second.price;
        }

        public static bool operator != (Car first, Car second)
        {
            return !(first.name == second.name && first.price == second.price);
        }

        public override string ToString()
        {
            return $"Name: {name} Color: {color} Price: {price}";
        }

    }
}


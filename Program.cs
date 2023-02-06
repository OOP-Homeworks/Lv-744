using System;

namespace Task_4_2023


{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.Input();
            Car car2 = new Car();
            car2.Input();
            Car car3 = new Car();
            car3.Input();
            car1.Output();
            car2.Output();
            car3.Output();
            Console.Write("Enter sale percent : ");
            double percent = Convert.ToDouble(Console.ReadLine());
            car1.ChangePrice(percent);
            car2.ChangePrice(percent);
            car3.ChangePrice(percent);
            Console.Write("Car data after change price SALE :");
            car1.Output();
            car2.Output();
            car3.Output();
            Console.Write("Enter color to repaint white cars : ");
            string newColor = Console.ReadLine();
            car1.Repaint(car1, newColor);
            car2.Repaint(car2, newColor);
            car3.Repaint(car3, newColor);
            car1.Output();
            car2.Output();
            car3.Output();
            Console.WriteLine("Checking same cars in garage : ");
            if (car1 == car2) Console.WriteLine($"Same cars{car1.name} & {car2.name}");
            else if (car1 == car3) Console.WriteLine($"Same cars {car1.name} & {car3.name}");
            else if (car2 == car3) Console.WriteLine($"Same cars {car2.name} & {car3.name} ");
            else Console.WriteLine("Not the same car ");






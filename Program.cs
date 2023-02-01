using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a color: ");
            string color = Console.ReadLine();
            Car car = new Car(color);
            Car car2 = new Car(color);
            Car car3 = new Car(color);
            Console.WriteLine(car.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(car3.ToString());


            car.Print();
            car2.Print();
            car3.Print();
            Console.WriteLine(car.ToString());
            Console.WriteLine(car2.ToString());
            Console.WriteLine(car3.ToString());
            Console.WriteLine(car.ChangePrice());
            Console.WriteLine();




            //HomeWork
            
            Person person1 = new Person();
            Person person2 = new Person();
            Person person3 = new Person();
            Person person4 = new Person();
            Person person5 = new Person();
            Person person6 = new Person();

            person1.Input();
            person2.Input();
            person3.Input();
            person4.Input();
            person5.Input();
            person6.Input();

            person1.Output();
            person2.Output();
            person3.Output();
            person4.Output();
            person5.Output();
            person6.Output();

            person1.ChangeName();
            person2.ChangeName();
            person3.ChangeName();
            person4.ChangeName();
            person5.ChangeName();
            person6.ChangeName();

            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.WriteLine(person3.ToString());
            Console.WriteLine(person4.ToString());
            Console.WriteLine(person5.ToString());
            Console.WriteLine(person6.ToString());




        }
    }
}

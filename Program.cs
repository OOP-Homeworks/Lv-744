
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



            //Task_1

            int area, perimeter, side;
            Console.Write("Enter square side : ");
            side = int.Parse(Console.ReadLine());

            perimeter = side * 2;
            area = (int)Math.Pow(side,2);
            Console.WriteLine($"Area = {area}, perimeter = {perimeter}");

            //Task_2


            int a;
            int sqareArea;
            int sqarePerimeter;
            Console.Write("Enter length of sqare side : ");
            a = Int32.Parse(Console.ReadLine());
            sqareArea = a * a;
            sqarePerimeter = a * 4;
            Console.WriteLine("Area - {0} , Perimeter - {1}", sqareArea, sqarePerimeter);
            

            string name;
            int age;
            Console.WriteLine("What is your name ?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you, {0} ?",name);
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Name - {0}, Age - {1}", name, age);

            double r;
            double circleLength;
            double circleArea;
            double circleVolume;
            Console.Write("Enter radius of circle : ");
            r = Double.Parse(Console.ReadLine());
            circleLength = 2 * Math.PI * r;
            circleArea = Math.PI * r * r;
            circleVolume = (4 * Math.PI * r * r * r) / 3;
            Console.WriteLine("Length - {0}, Area - {1}, Volume - {2}", 
                circleLength, circleArea, circleVolume);



            Console.ReadLine();
        }
    }
}




            //Task_1

            int area, perimeter, side;
            Console.Write("Enter square side : ");
            side = int.Parse(Console.ReadLine());

            perimeter = side * 2;
            area = (int)Math.Pow(side,2);
            Console.WriteLine($"Area = {area}, perimeter = {perimeter}");

            //Task_2

            string name;
            int age;
            Console.WriteLine("\nHi, what is your name ? ");
            name = Console.ReadLine();
            Console.WriteLine($"How old are you {name} ?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and you {age} years old.");

            //Task_3

            double radius, length, area1, volume;

            Console.Write("\nEnter circle radius : ");
            radius = Convert.ToDouble(Console.ReadLine());
            length = Math.Round((2 * Math.PI * radius), 2);
            area1 = Math.Round(( Math.PI * Math.Pow(radius, 2)), 2);
            volume = Math.Round(( 4/3 * Math.PI * Math.Pow(radius, 3)),2);
            Console.WriteLine($"We have circle with volume {volume}, length {length} and area {area1}");

        }
    }
}



using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

namespace Homework._2
    internal partial class Program
{
    internal class Program
    {
        public static object HTTP { get; private set; }
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    //TASK1
                    Console.Clear();

                    Console.WriteLine("Enter 3 numbers:");
                    float firstNumb = float.Parse(Console.ReadLine());
                    float secondNumb = float.Parse(Console.ReadLine());
                    float thirdNumb = float.Parse(Console.ReadLine());
                    string chek = firstNumb >= -5 && firstNumb <= 5 &&
                        secondNumb >= -5 && secondNumb <= 5 &&
                        thirdNumb >= -5 && thirdNumb <= 5 ? "True" : "False";
                    Console.WriteLine(chek);
                    Console.WriteLine();

                    //TASK2
                    Console.WriteLine("Enter three numbers: ");
                    int firstNumb1 = int.Parse(Console.ReadLine());
                    int secondNumb2 = int.Parse(Console.ReadLine());
                    int thirdNumb3 = int.Parse(Console.ReadLine());
                    int[] array = new int[3];
                    Console.WriteLine();
                    for (int i = 0; i < 1; i++)
                    {
                        array[0] = firstNumb1;
                        array[1] = secondNumb2;
                        array[2] = thirdNumb3;
                    }
                    Console.WriteLine("The min is: " + array.Min() + " ");
                    Console.WriteLine("The max is: " + array.Max());
                }
                
                //TASK4
              
            public struct Dog
        {
            public string name;
            public string mark;
            public int age;
            public Dog (string name, string mark, int age)
            {
                this.name=name;
                this.mark=mark;
                this.age=age;
                Console.WriteLine();
                {






































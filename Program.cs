using SayHi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>()
        {
            new Circle(3),
            new SayHi.Square(4),
            new Circle(5),
            new SayHi.Square(6),
            new Circle(1),
            new SayHi.Square(2)
        };
        


        var shapesRange = shapes.Where(shape => shape.GetArea() >= 10 && shape.GetArea() <= 100);
        WriteShapesToFile(shapesRange, "shapesRange.txt");

        
        var shapesA = shapes.Where(shape => shape.GetName().Contains('a'));
        WriteShapesToFile(shapesA, "shapesA.txt");

        
        shapes.RemoveAll(shape => shape.GetPerimeter() < 5);

        
        Console.WriteLine("Shapes with perimeter >= 5:");
        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetName()}: perimeter = {shape.GetPerimeter()}, area = {shape.GetArea()}");
        }

        //task 2

       
        string[] lines = File.ReadAllLines("text.txt");

        
        foreach (string line in lines)
        {
            Console.WriteLine($"Line {Array.IndexOf(lines, line) + 1} has {line.Length} symbols");
        }

        
        string LongLine = lines[0];
        string ShortLine = lines[0];
        foreach (string line in lines)
        {
            if (line.Length > LongLine.Length)
            {
                LongLine = line;
            }
            if (line.Length < ShortLine.Length)
            {
                ShortLine = line;
            }
        }
        Console.WriteLine($"Longest line: {LongLine}");
        Console.WriteLine($"Shortest line: {ShortLine}");   
        Console.WriteLine("Lines with the word \"var\":");
        foreach (string line in lines)
        {
            if (line.Contains("var"))
            {
                Console.WriteLine(line);
            }
        }
    }

    static void WriteShapesToFile(IEnumerable<Shape> shapes, string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var shape in shapes)
            {
                writer.WriteLine($"{shape.GetName()}: perimeter = {shape.GetPerimeter()}, area = {shape.GetArea()}");
            }
        }
    }
}


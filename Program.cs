namespace _23022023_HomeWork_10
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            const int sizeNum = 3;
            Point start = new Point(0, 0);
            double min = double.MaxValue;
            int minTriangle = 0;
            var list = new List<Triangle>();

            for (int i = 0; i < sizeNum; i++)
            {
                Point[] vertexes = new Point[3];

                for (int j = 0; j < 3; j++)
                {
                    vertexes[j] = new Point(rnd.NextDouble(), rnd.NextDouble());
                }

                try
                {
                    var triangle = new Triangle(vertexes[0], vertexes[1], vertexes[2]);
                    if (triangle.IsValid())
                    {
                        double distance = vertexes[0].Distance(start) + vertexes[1].Distance(start) + vertexes[2].Distance(start);
                        if (distance < min)
                        {
                            min = distance;
                            minTriangle = i;
                        }
                        list.Add(triangle);
                    }
                }
                catch (ArgumentException)
                {
                    i--;
                }
            }

            list[minTriangle].Print();

            Console.ReadLine();
        }
    }
}

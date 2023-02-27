namespace HW10
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Triangle> triangles = new List<Triangle>();

            Point [] points = new Point[]
            {
                new Point() {x=0, y = 0 }, new Point() {x=2,y=5}, new Point() {x = 8, y=3},
                new Point() {x=2, y = 10 }, new Point() {x=8,y=6}, new Point() {x = 1, y=4},
                new Point() {x=1, y = 4 }, new Point() {x=4,y=3}, new Point() {x = 3, y=7} 
            };
            triangles.Add(new Triangle(points[0], points[1], points[2]));
            triangles.Add(new Triangle(points[3], points[4], points[5]));
            triangles.Add(new Triangle(points[6], points[7], points[8]));
        }

        public struct Point
        {
            public int x, y;

            public Point(int v1, int v2) : this()
            {
                this.x = v1;
                this.y = v2;
            }

            public override string ToString()
            {
                return x.ToString() + "," + y.ToString();
            }
        }
    }
}
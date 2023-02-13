using System.Collections.Generic;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <IDeveloper> developers = new List<IDeveloper>();
            Builder builder1 = new Builder("John", "1C");
            Builder builder2 = new Builder("Mark", "C#");
            developers.Add(builder1);
            developers.Add(builder2);
            Programmer programmer1 = new Programmer("Ben","MacBook");
            Programmer programmer2 = new Programmer("Filip","Acer");
            developers.Add(programmer1);
            developers.Add(programmer2);
            foreach (IDeveloper devel in developers)
            {
                devel.Create();
                devel.Destroy();
            }
            developers.Sort();
        }
    }
}

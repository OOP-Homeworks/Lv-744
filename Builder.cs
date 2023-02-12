using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture5_744
{
    internal class Builder : IDeveloper
    {
        string tool;
        public string Tool { get { return tool; } }

        public Builder(string tool)
        { this.tool = tool; }

        public void Create()
        {
            Console.WriteLine($"Builder using = {tool}");
        }
        public void Destroy()
        {
            tool = tool.Remove(0);
            Console.WriteLine($"Builder destroyed all with = {tool}");
        }

        public int CompareTo(IDeveloper? otherObj)
        {
            if (otherObj == null) return 1;
            return string.Compare(Tool, otherObj.Tool);
        }
    }
}

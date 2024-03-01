using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Kettle : Device
    {
        public Kettle(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine($"The {Name} is boiling water");
        }
    }
}

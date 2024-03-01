using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Steamer : Device
    {
        public Steamer(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine($"The {Name} is steaming vegetables");
        }
    }
}

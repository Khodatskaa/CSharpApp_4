using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Car : Device
    {
        public Car(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine($"The {Name} is revving its engine");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a {Name}. It is a mode of transportation");
        }
    }
}

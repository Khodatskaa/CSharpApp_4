using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpApp_4
{
    public class Violin : MusicalInstrument
    {
        public Violin(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine($"The {Name} is playing classical music.");
        }

        public override void Desc()
        {
            Console.WriteLine($"This is a {Name}. It is a string instrument.");
        }
    }
}

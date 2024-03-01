using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpApp_4
{
    public class Trombone : MusicalInstrument
    {
        public Trombone(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine($"The {Name} is playing jazz music.");
        }
    }
}

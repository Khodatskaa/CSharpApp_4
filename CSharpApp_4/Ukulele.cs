using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpApp_4
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name) : base(name) { }

        public override void Sound()
        {
            Console.WriteLine($"The {Name} is playing Hawaiian tunes.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class MusicalInstrument
    {
        protected string Name;

        public MusicalInstrument(string name)
        {
            Name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"The {Name} is making a sound.");
        }

        public void Show()
        {
            Console.WriteLine($"Musical Instrument Name: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"This is a {Name}.");
        }

        public virtual void History()
        {
            Console.WriteLine($"The {Name} has a rich history of creation.");
        }
    }

}

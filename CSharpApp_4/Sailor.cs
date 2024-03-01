using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpApp_4
{
    class Sailor : Human
    {
        public required string SailingExperience { get; set; }

        public void Sail()
        {
            Console.WriteLine($"{Name} is a sailor with {SailingExperience} sailing experience");
        }
    }
}

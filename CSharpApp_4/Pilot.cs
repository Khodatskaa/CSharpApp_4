using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpApp_4
{
    class Pilot : Human
    {
        public required string FlyingExperience { get; set; }  //public required string - is used to define a required property in a class

        public void Fly()
        {
            Console.WriteLine($"{Name} is a pilot with {FlyingExperience} flying experience");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Device
    {
        protected string Name;

        public Device(string name)
        {
            Name = name;
        }

        public virtual void Sound()
        {
            Console.WriteLine($"The {Name} is making a sound");
        }

        public void Show()
        {
            Console.WriteLine($"Device Name: {Name}");
        }

        public virtual void Desc()
        {
            Console.WriteLine($"This is a {Name}");
        }
    }
}

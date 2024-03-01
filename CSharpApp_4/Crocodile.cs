using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Crocodile : Animal
    {
        public bool IsDangerous { get; set; }

        public Crocodile(string name, bool isDangerous) : base(name)
        {
            IsDangerous = isDangerous;
        }

        public void DisplayCrocodileInfo()
        {
            DisplayInfo();
            Console.WriteLine($"I am a {(IsDangerous ? "dangerous" : "not dangerous")} crocodile");
        }
    }
}

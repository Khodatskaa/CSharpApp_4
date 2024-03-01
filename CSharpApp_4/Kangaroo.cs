using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Kangaroo : Animal
    {
        public int JumpHeight { get; set; }

        public Kangaroo(string name, int jumpHeight) : base(name)
        {
            JumpHeight = jumpHeight;
        }

        public void DisplayKangarooInfo()
        {
            DisplayInfo();
            Console.WriteLine($"I am a kangaroo with a jump height of {JumpHeight} meters");
        }
    }
}

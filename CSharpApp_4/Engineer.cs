using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Engineer: Develops and maintains technology or infrastructure");
        }
    }
}

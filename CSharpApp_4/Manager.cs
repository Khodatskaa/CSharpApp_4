using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager: Manages operations and resources");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("President: Oversees the entire organization");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    class Builder : Human
    {
        public required string ConstructionSkill { get; set; }

        public void Build()
        {
            Console.WriteLine($"{Name} is a builder and can build with {ConstructionSkill} skill");
        }
    }
}

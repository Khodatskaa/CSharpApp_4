using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class RightTriangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Tiger : Animal
    {
        public string StripePattern { get; set; }

        public Tiger(string name, string stripePattern) : base(name)
        {
            StripePattern = stripePattern;
        }

        public void DisplayTigerInfo()
        {
            DisplayInfo();
            Console.WriteLine($"I am a tiger with a stripe pattern: {StripePattern}");
        }
    }
}

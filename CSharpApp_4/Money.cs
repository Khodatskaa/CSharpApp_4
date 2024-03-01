using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Money
    {
        private int wholePart;
        private int fractionalPart;

        public string Currency { get; private set; }

        public Money(int wholePart, int fractionalPart, string currency)
        {
            this.wholePart = wholePart;
            this.fractionalPart = fractionalPart;
            Currency = currency;
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Amount: {wholePart} whole part and {fractionalPart} fractional part ({Currency})");
        }

        public void SetAmount(int newWholePart, int newFractionalPart)
        {
            wholePart = newWholePart;
            fractionalPart = newFractionalPart;
        }

        public void SetCurrency(string newCurrency)
        {
            Currency = newCurrency;
        }

        public int WholePart => wholePart;
        public int FractionalPart => fractionalPart;
    }
}

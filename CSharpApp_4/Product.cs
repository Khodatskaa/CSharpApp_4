using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Product
    {
        private string productName;
        private Money price;

        public Product(string productName, Money price)
        {
            this.productName = productName;
            this.price = price;
        }

        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product: {productName}");
            price.DisplayAmount();
        }

        public void ReducePrice(int reductionAmount)
        {
            int newFractionalPart = price.FractionalPart - reductionAmount;

            if (newFractionalPart < 0)
            {
                price.SetAmount(price.WholePart - 1, 100 + newFractionalPart);
            }
            else
            {
                price.SetAmount(price.WholePart, newFractionalPart);
            }
        }
    }
}

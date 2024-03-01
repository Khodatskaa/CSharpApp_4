namespace CSharpApp_4
{
    public class Program
    {
        static void Main()
        {
            Money money = new Money(50, 75, "USD");
            money.DisplayAmount();
            money.SetAmount(60, 20);
            money.DisplayAmount();

            money.SetCurrency("EUR");
            money.DisplayAmount();

            Money productPrice = new Money(100, 50, "USD");
            Product product = new Product("Example Product", productPrice);
            product.DisplayProductInfo();

            Console.WriteLine("Reducing the price by 30");
            product.ReducePrice(30);
            product.DisplayProductInfo();
        }
    }
}

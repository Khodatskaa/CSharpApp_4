namespace CSharpApp_4
{
    internal class Program
    {
        static void Main()
        {
            Kettle kettle = new Kettle("Electric Kettle");
            Microwave microwave = new Microwave("Microwave Oven");
            Car car = new Car("Sports Car");
            Steamer steamer = new Steamer("Vegetable Steamer");

            kettle.Sound();
            kettle.Show();
            kettle.Desc();
            Console.WriteLine();

            microwave.Sound();
            microwave.Show();
            microwave.Desc();
            Console.WriteLine();

            car.Sound();
            car.Show();
            car.Desc();
            Console.WriteLine();

            steamer.Sound();
            steamer.Show();
            steamer.Desc();
        }
    }
}

namespace CSharpApp_4
{
    internal class Program
    {
        static void Main()
        {
            Tiger tiger = new Tiger("Stripes", "Distinctive");
            Crocodile crocodile = new Crocodile("Snappy", true);
            Kangaroo kangaroo = new Kangaroo("Jumpy", 3);

            tiger.DisplayTigerInfo();
            Console.WriteLine();

            crocodile.DisplayCrocodileInfo();
            Console.WriteLine();

            kangaroo.DisplayKangarooInfo();
        }
    }
}

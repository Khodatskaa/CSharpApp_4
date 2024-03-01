namespace CSharpApp_4
{
    internal class Program
    {
        static void Main()
        {
                Violin violin = new Violin("Violin");
                Trombone trombone = new Trombone("Trombone");
                Ukulele ukulele = new Ukulele("Ukulele");
                Cello cello = new Cello("Cello");

                violin.Sound();
                violin.Show();
                violin.Desc();
                violin.History();
                Console.WriteLine();

                trombone.Sound();
                trombone.Show();
                trombone.Desc();
                trombone.History();
                Console.WriteLine();

                ukulele.Sound();
                ukulele.Show();
                ukulele.Desc();
                ukulele.History();
                Console.WriteLine();

                cello.Sound();
                cello.Show();
                cello.Desc();
                cello.History();
        }
    }
}

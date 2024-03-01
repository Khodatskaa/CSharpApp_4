namespace CSharpApp_4
{
    internal class Program
    {
        static void Main()
        {
            List<Worker> workers = new List<Worker>
            {
                new President(),
                new Security(),
                new Manager(),
                new Engineer()
            };

            foreach (var worker in workers)
            {
                worker.Print();
            }
        }
    }
}

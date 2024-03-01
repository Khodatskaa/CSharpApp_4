namespace CSharpApp_4
{
    public class Program
    {
        static void Main()
        {
            Builder builder = new Builder
            {
                Name = "John",
                Age = 30,
                ConstructionSkill = "Carpentry"    //carpentry - столярство
            };

            Sailor sailor = new Sailor
            {
                Name = "Alice",
                Age = 25,
                SailingExperience = "10 years"
            };

            Pilot pilot = new Pilot
            {
                Name = "Bob",
                Age = 35,
                FlyingExperience = "Commercial Pilot License"
            };

            builder.Build();
            sailor.Sail();
            pilot.Fly();
        }
    }
}

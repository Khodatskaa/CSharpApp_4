using System;

namespace CSharpApp_4
{
    public class Program
    {
        static void Main()
        {
            Passport regularPassport = new Passport
            {
                FullName = "John Doe",
                PassportNumber = "AB123456",
                DateOfBirth = new DateTime(1980, 5, 15)
            };

            ForeignPassport foreignPassport = new ForeignPassport
            {
                FullName = "Jane Smith",
                PassportNumber = "CD789012",
                DateOfBirth = new DateTime(1992, 8, 20),
                VisaInformation = "Tourist visa, valid until 2023",
                ForeignPassportNumber = "FG456789",
                Country = "SomeCountry",
                ExpiryDate = new DateTime(2025, 12, 31)
            };

            Console.WriteLine("Regular Passport Information:");
            regularPassport.DisplayPassportInfo();
            Console.WriteLine();

            Console.WriteLine("Foreign Passport Information:");
            foreignPassport.DisplayForeignPassportInfo();
            foreignPassport.ApplyForVisa(); 
        }
    }
}

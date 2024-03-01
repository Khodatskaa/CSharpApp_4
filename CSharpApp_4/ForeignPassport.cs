using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class ForeignPassport : Passport, Visa
    {
        public required string Country { get; set; }
        public DateTime ExpiryDate { get; set; }
        public required string VisaInformation { get; set; }
        public string? ForeignPassportNumber { get; internal set; }

        public void ApplyForVisa()
        {
            Console.WriteLine($"Applying for a visa for {FullName} to visit {Country}.");
        }

        public void DisplayForeignPassportInfo()
        {
            Console.WriteLine($"Name: {FullName}\nPassport Number: {PassportNumber}\nDate of Birth: {DateOfBirth.ToShortDateString()}\nCountry: {Country}\nExpiry Date: {ExpiryDate.ToShortDateString()}\nVisa Information: {VisaInformation}");
        }
    }

    public interface Visa
    {
        void ApplyForVisa();
    }
}
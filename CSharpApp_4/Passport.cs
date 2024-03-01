using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_4
{
    public class Passport
    {
        public required string FullName { get; set; }
        public required string PassportNumber { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void DisplayPassportInfo()
        {
            Console.WriteLine($"Name: {FullName}\nPassport Number: {PassportNumber}\nDate of Birth: {DateOfBirth.ToShortDateString()}");
        }
    }
}

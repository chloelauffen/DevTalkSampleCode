using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Person
    {
        // Example of Auto Property Initializer
        public string FirstName { get; set; } = "Chloe";

        // Example of Getter Only Property
        public string LastName { get; } = "Lauffenburger";

        public List<string> PhoneNumbers { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Example of Return Tuple Values
        public (string, string, DateTime) GetInfo()
        {
            return ("burritos", "tacos", new DateTime());
        }
    }
}

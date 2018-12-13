using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Person
    {
        // Example of auto property initializer 
        public string FirstName { get; set; } = "Chloe";
        // Example of getter only property
        public string LastName { get; } = "Lauffenburger";

        public List<string> PhoneNumbers { get; set;  }
        public DateTime DateOfBirth { get; set; }
    }
}

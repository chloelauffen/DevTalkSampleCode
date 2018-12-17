using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class Cow : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Moo");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public interface IAnimal
    {
        void MakeSound();
        
        // Example of default implementation with C# 8
        //void MakeSound() {
        //    Console.WriteLine("no sounds yet");
        //}
    }
}

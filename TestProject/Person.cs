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
        //void MakeSound() {
        //    Console.WriteLine("no sounds yet");
        //}
    }

    public class Cow : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Moo");
        }
    }

    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            throw new NotImplementedException();
        }
    }






    public class Person
    {
        public string FirstName { get; set; } = "Chloe";
        public string LastName { get; } = "Lauffenburger";
        public readonly string Hello = "HI";

        public List<string> PhoneNumbers { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Example of Tuple return values


        public (string, string, DateTime) GetInfo()
        {
            return ("burritos", "tacos", new DateTime());
        }

        // Example of Tuple return values

        public (string, string, DateTime) ReplaceFirstName(string newFirstName)
        {
            return (newFirstName, LastName, DateOfBirth);
        }

        public Person()
        {
            FirstName = "HI";
            LastName = "HELLO";
            Hello = "HEY";


            (string, string, DateTime) myTuple = GetInfo();
            // myTuple.Item1;
            // myTuple.Item2;
            // myTuple.Item3;

            var (lunch, dinner, dinnerTime) = GetInfo();

            (string breakfast, string snack, DateTime snackTime) = GetInfo();



        }
    }
}

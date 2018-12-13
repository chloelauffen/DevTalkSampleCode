using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchStatementPatternMatchingExample();
        }

        /*
         * C#7 & C#7.1
         * */



        public static void SwitchStatementPatternMatchingExample()
        {
            Match("string");
            Match(500);
            Match(100);
            Match(new List<string>() { "value1", "value2" });
            Match(new Person());
        }
        public static void Match(object myVar)
        {
            switch (myVar)
            {
                case string str:
                    {
                        Console.WriteLine($"we assigned the value to str {str}");
                        break;
                    }
                case int i when i <= 100:
                    {
                        Console.WriteLine($"{i} is an int and less than or equal to 100");
                        break;
                    }
                case int i:
                    {
                        Console.WriteLine($"{i} is an int and is greater than 100");
                        break;
                    }
                case IEnumerable<object> list when list.Any():
                    {
                        Console.WriteLine($"we assigned the value to list {string.Join(", ", list)}");
                        break;
                    }
                case Person p when (p.FirstName == "Chloe"):
                    {
                        Console.WriteLine($"we assigned the value to p {p.FirstName}");
                        break;
                    }
            }
        }

        /*
         * C#6
         * */
        public static void StringInterpolationAndDateFormattingExample()
        {
            // Example of string interpolation
            // Example of Date Formatting
            var person = new Person() { DateOfBirth = new DateTime(1993, 1, 25) };
            var message = $"Person {person.FirstName} {person.LastName} was born on {person.DateOfBirth: MMM dd, yyyy}";
        }

        public static void NullPropagationOperatorExample()
        {
            // null-conditional and null-coalescing
            // Example of null propagation operator
            var person = new Person();
            string firstNumber;

            // NULL example
            if (person != null && person.PhoneNumbers != null && person.PhoneNumbers[0] != null)
            {
                firstNumber = person.PhoneNumbers[0];
            }
            else
            {
                firstNumber = "alternative";
            }

            // VS
            firstNumber = person?.PhoneNumbers?[0] ?? "alternative";

            // NOT NULL example
            person.PhoneNumbers = new List<string>() { "123456789" };
            if (person != null && person.PhoneNumbers != null && person.PhoneNumbers[0] != null)
            {
                firstNumber = person.PhoneNumbers[0];
            }
            else
            {
                firstNumber = "alternative";
            }
            // VS
            firstNumber = person?.PhoneNumbers?[0] ?? "alternative";
        }

        public static void NameOfExample()
        {
            // Example of "nameOf" feature
            var variableName = "string value";
            var test = nameof(variableName);
            Console.WriteLine(test);
        }

        public static void GetterOnlyPropertyExample()
        {
            // Example of getter only property
            var person = new Person
            {
                FirstName = "NewFirstName",
                //LastName = "NewLastName"
            };
        }

        public static void ExceptionFilterExample()
        {
            // Example of exception filters
            // only enters the catch block if matches the filter
            try
            {
                throw new Exception("My Exception");
            }
            catch (Exception ex) when (ex.Message == "Other Exception")
            {
                Console.WriteLine("Other Exception occurred");
            }
            catch (Exception ex) when (ex.Message == "My Exception")
            {
                Console.WriteLine("My Exception occurred");
            }
            // VS
            // will always enter the catch block and can be rethrown
            try
            {
                throw new Exception("My Exception");
            }
            catch (Exception ex)
            {
                if (ex.Message == "Other Exception")
                {
                    Console.WriteLine("Other Exception occurred");
                }
                else if (ex.Message == "My Exception")
                {
                    Console.WriteLine("My Exception occurred");
                }
                else
                {
                    throw;
                }
            }
            //https://www.thomaslevesque.com/2015/06/21/exception-filters-in-c-6/
        }
    }
}

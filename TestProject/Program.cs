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
            TupleEqualityComparisons();
        }

        /*
         *  C#7.3
         * */

        public static void TupleEqualityComparisons()
        {

            string str1 = null;

            // string? str2 = null;


            Console.WriteLine(str1);

            var lunch = (3, "tacos");
            var dinner = (3, "tacos");

            bool isSameMeal = lunch == dinner;
            // true


            //var lunch = (5, "burritos");
            //var dinner = (3, "tacos");

            //bool isSameMeal = lunch == dinner;
            //// false




            var tuple = (5, "Orange");

            var count2 = 5;
            var type2 = "Yellow";
            var tuple2 = (count2, type2);

            bool isSame = tuple == tuple2;

            tuple2.type2 = "Orange";

            isSame = tuple == tuple2;
        }

        /*
         *  C#7.1
         * */

        public static void DefaultLiteralsExample()
        {




            string myStr = default;     // null
            int myInt = default;        // 0


            Console.WriteLine(myStr);
            Console.WriteLine(myInt);
        }

        public static void TupleNameInferenceExample()
        {



            string food = "burritos";
            int amount = 5;

            var lunch = (amount, food);

            string message = $"Lunch was {lunch.amount} cool {lunch.food}";
            // Lunch was 5 cool burritos



            // need to install System.ValueTuple
            var count = 5;
            var type = "Orange";

            var tuple = (count, type);

            Console.WriteLine($"count: {tuple.count}; type: {tuple.type}");
        }

        /*
         * C#7
         *
        */
        public static void TupleDeconstructionExample()
        {
            var person = new Person();

            (string, string, DateTime) myTuple = person.GetInfo();

            var (first, last, date) = person.GetInfo();
            (string first2, string last2, DateTime date2) = person.GetInfo();
        }

        public static void SwitchStatementPatternMatchingExample()
        {
            SwitchStatementPatternMatchingExample("string");
            SwitchStatementPatternMatchingExample(500);
            SwitchStatementPatternMatchingExample(100);
            SwitchStatementPatternMatchingExample(new List<string>() { "value1", "value2" });
            SwitchStatementPatternMatchingExample(new Person());
        }

        public static void SwitchStatementPatternMatchingExample(object myParam)
        {
            object myObject = "hello";
            // object myObject = 10;
            // object myObject = 500;
            // object myObject = new List<string>();
            // object myObject = new Person();
            switch (myObject)
            {
                case string myStr:
                    {
                        break;
                    }
                case int myInt when myInt <= 100:
                    {
                        break;
                    }
                case int myInt:
                    {
                        break;
                    }
                case IEnumerable<object> myEnumerable when myEnumerable.Any():
                    {
                        break;
                    }
                case Person myPerson when (myPerson.FirstName == "Chloe"):
                    {
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

            string name = "Chloe";
            DateTime dob = new DateTime(1993, 1, 25);

            var message = $"{name} was born on {dob: MMM dd, yyyy}";
            // Chloe was born on  Jan 25, 1993



            //var person = new Person() { DateOfBirth = new DateTime(1993, 1, 25) };
            //var message = $"Person {person.FirstName} {person.LastName} was born on {person.DateOfBirth: MMM dd, yyyy}";
        }

        public static void NullPropagationOperatorExample()
        {
            List<string> list = null;

            string firstItem = list?[0]?.ToLower();



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

            string food = "burritos";
            string myVar = nameof(food);
            // myVar has value "food"

            Console.WriteLine(myVar);
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
            try
            {
                ThrowException();
            }
            catch (Exception ex) when (ex.Message == "Other Exception")
            {
            }
            catch (Exception ex) when (ex.Message == "My Exception")
            {
            }

            try
            {
                ThrowException();
            }
            catch (Exception ex)
            {
                if (ex.Message == "Other Exception")
                {
                }
                else if (ex.Message == "My Exception")
                {
                }
                else
                {
                    throw;
                }
            }
        }

        public static void ThrowException()
        {
            throw new Exception("My Exception");
        }
    }
}

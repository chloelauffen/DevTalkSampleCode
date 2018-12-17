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
            // call methods below to test them out with the debugger!  :)
        }

        /*
         * C#6
         * */

        // Example of String Interpolation w/ Date Formatting
        public static void StringInterpolationAndDateFormattingExample()
        {
            string name = "Chloe";
            DateTime dob = new DateTime(1993, 1, 25);

            var message = $"{name} was born on {dob: MMM dd, yyyy}";
            // Chloe was born on  Jan 25, 1993
        }

        // Example of Null-Conditional Operator 1
        public static void NullPropagationOperatorExample1()
        {
            List<string> list = null;
            string firstItem = list?[0]?.ToLower();
        }

        // Example of Null-Conditional Operator 2
        public static void NullPropagationOperatorExample2()
        {
            var person = new Person();
            string firstNumber;

            // NULL example
            // this block of code
            if (person != null && person.PhoneNumbers != null && person.PhoneNumbers[0] != null)
            {
                firstNumber = person.PhoneNumbers[0];
            }
            else
            {
                firstNumber = "alternative";
            }
            // is equivalent to this line of code
            firstNumber = person?.PhoneNumbers?[0] ?? "alternative";

            // 'firstNumber' now has value "alternative"

            // NOT NULL example
            person.PhoneNumbers = new List<string>() { "123456789" };
            // this block of code
            if (person != null && person.PhoneNumbers != null && person.PhoneNumbers[0] != null)
            {
                firstNumber = person.PhoneNumbers[0];
            }
            else
            {
                firstNumber = "alternative";
            }
            // is equivalent to this line of code
            firstNumber = person?.PhoneNumbers?[0] ?? "alternative";

            // 'firstNumber' now has value "123456789"
        }

        // Example of nameOf Keyword
        public static void NameOfExample()
        {
            string food = "burritos";
            string myVar = nameof(food);
            // myVar has value "food"
        }

        // Example of Exception Filters
        public static void ExceptionFilterExample()
        {
            // using Exception Filters
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

            // similar intent without using Exception Filters
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

        /*
         * C#7
         *
        */

        // Example of Tuple Deconstruction
        public static void TupleDeconstructionExample()
        {
            var person = new Person();

            (string, string, DateTime) myTuple = person.GetInfo();
            // myTuple.Item1;
            // myTuple.Item2;
            // myTuple.Item3;

            var (lunch, dinner, dinnerTime) = person.GetInfo();

            (string breakfast, string snack, DateTime snackTime) = person.GetInfo();
        }

        // Example of Switch Statement Pattern Matching
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

        public static void SwitchStatementPatternMatchingExample()
        {
            SwitchStatementPatternMatchingExample("string");
            SwitchStatementPatternMatchingExample(500);
            SwitchStatementPatternMatchingExample(100);
            SwitchStatementPatternMatchingExample(new List<string>() { "value1", "value2" });
            SwitchStatementPatternMatchingExample(new Person());
        }

        /*
         *  C#7.1
         * */

        // Example of Default Literals
        public static void DefaultLiteralsExample()
        {
            string myStr = default;     // null
            int myInt = default;        // 0
        }

        // Example of Inferred Tuple Element Names
        // need to install System.ValueTuple
        public static void TupleNameInferenceExample()
        {
            // explicit element names
            var count = 5;
            var type = "Orange";

            var tuple = (count: count, type: type);

            // inferred element names
            string food = "burritos";
            int amount = 5;

            var lunch = (amount, food);

            string message = $"Lunch was {lunch.amount} cool {lunch.food}";
            // Lunch was 5 cool burritos
        }

        /*
         *  C#7.3
         * */

        // Example of Tuple Equality Comparison
        public static void TupleEqualityComparisons()
        {
            var lunch = (3, "tacos");
            var dinner = (3, "tacos");

            bool isSameMeal = lunch == dinner;
            // true

            var lunch2 = (5, "burritos");
            var dinner2 = (3, "tacos");

            bool isSameMeal2 = lunch2 == dinner2;
            // false
        }
    }
}

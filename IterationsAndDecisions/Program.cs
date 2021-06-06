using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoopexamples();
            ForEachLoopExamples();
            LinqQueryOverInts();
            WhileLoopExamples();
            DoWhileLoop();
            ExecutingIfElseUsingConditionalOperator();
            ExecutingIfThenElse();
            SwitchExamples();
            switchOnStringExample();
            SwitchOnEnumExample();
            ExecutePatternMatchingSwitch();
            ExecutePatternMatchingSwitchWithWhen();

            Console.ReadLine();
        }

        private static void ExecutePatternMatchingSwitchWithWhen()
        {
            Console.WriteLine("1[c#], 2 [vb]");
            Console.Write("Please, pick your language preference");
            object langChoice = Console.ReadLine();
            var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;

            switch (choice)
            {
                case int i when i == 2:
                case string s when s.Equals("vb", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("VB: OOP, multithreading, and more");
                    break;
                case int i when i == 1:
                case string s when s.Equals("c#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine( "Good choice c# is a fine language");
                    break;
                default:
                    Console.WriteLine("carry on with that");
                    break;

            }
        }

        private static void ExecutePatternMatchingSwitch()
        {
            Console.WriteLine("1 [Integer (5)], 2[String (\"Hi \")], 3[decimal (2.5)]");
            Console.Write("choose an option");
            string userChoice = Console.ReadLine();
            object choice;

            // this is a standard constant pattern swicth statement to set up the example
            switch (userChoice)
            {
                case "1":
                    choice = 5;
                    break;
                case "2":
                    choice = "Hi";
                    break;
                case "3":
                    choice = 2.5;
                    break;
                default:
                    choice = 5;
                    break;

            }

            // this is a new pattern matching switch statement
            switch (choice)
            {
                case int i:
                    Console.WriteLine("Your choice is an integer {0}",i);
                    break;
                case string s:
                    Console.WriteLine("your choice is string {0}",s);
                    break;
                case decimal d:
                    Console.WriteLine("your choice is a decimal {0}",d);
                    break;
                default:
                    Console.WriteLine("Your choice is something else");
                    break;
                    
            }
            Console.WriteLine();
        }

        private static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter your favourite day of the week");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());

            }
            catch(Exception ex)
            {
                Console.WriteLine("Bad input");
                return;
            }
            
            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Field Service");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Its a week end");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another working day");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Work continues");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Try Field Service");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Getting to weekend");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("TGIS");
                    break;
                default:
                    Console.WriteLine("Have a nice day");
                    break;
            }

        }

        private static void switchOnStringExample()
        {
            Console.WriteLine("c#, vb");
            Console.Write("Type programing language of your choice");
            Console.WriteLine();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "c#":
                    Console.WriteLine("Great! c# is a fine programming language");
                    break;
                case "vb":
                    Console.WriteLine("VB is not bad programming Language" +
                        " its also simple");
                    break;
                default:
                    Console.WriteLine("ok Have a nice day");
                    break;

            }
        }

        private static void SwitchExamples()
        {
            Console.WriteLine("1[c#], 2[vb]");
            Console.Write("Select programing language of your choice");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Great! c# is a fine programming language");
                    break;
                case 2:
                    Console.WriteLine("VB is not bad programming Language" +
                        " its also simple");
                    break;
                default:
                    Console.WriteLine("ok Have a nice day");
                    break;
                        
            }
        }

        private static void ExecutingIfThenElse()
        {
            string age = "";
            Console.WriteLine("working with if then else statement");
            Console.WriteLine("How Old are you?");
            age = Console.ReadLine();
            if (int.TryParse(age, out int age1))
            {
                if (age1 >= 11 && age1 <= 12)
                {
                    Console.WriteLine("I am Sure You are Jason! Because" +
                        " She is That Old");
                }
                else if (age1 >= 7 && age1 <= 8)
                {
                    Console.WriteLine("I am Sure You are Joan! Because" +
    " She is That Old");
                }
                else
                {
                    Console.WriteLine("you are not a member of this house as a child");
                }
            }
            else
            {
                Console.WriteLine("Please enter only digit");
            }


        }

        private static void ExecutingIfElseUsingConditionalOperator()
        {
            string age = "";
            Console.WriteLine("Working with conditional operator ?");
            Console.WriteLine("How Old are you?");
            age = Console.ReadLine();
            if( int.TryParse(age, out int age1))
            {
                Console.WriteLine(age1 >= 11 && age1 <= 12?"I am Sure You are Jason! Because" +
                        " He is That Old": "I am Sure You are Joan! Because" +
    " She       is That Old");
               
            }
            else
            {
                Console.WriteLine("Please enter only digit");
            }
        }

        private static void DoWhileLoop()
        {
            string userIsDone = "yes";
            do
            //test on a lower case copy of the string.
            {
                Console.WriteLine("In do While Loop");
                Console.Write("Are you done? [yes] [no]:");
                userIsDone = Console.ReadLine();
            } while (userIsDone != "yes") ;



        }

        private static void WhileLoopExamples()
        {
            string userIsDone = "";

            //test on a lower case copy of the string.
            while (userIsDone != "yes")
            {
                Console.WriteLine("In While Loop");
                Console.Write("Are you done? [yes] [no]:");
                userIsDone = Console.ReadLine();
            }

        }

        private static void LinqQueryOverInts()
        {
            int[] myInt = { 10, 20, 30, 40,1,2,3,8 };

            //LINQ query!
            var subset = from i in myInt where i < 10 select i;
            Console.Write("Values in sunset: ");

            foreach (var i in subset)
            {
                Console.Write("{0},\t", i);
            }
            Console.WriteLine();
        }

        private static void ForEachLoopExamples()
        {
            //Iterate array items using the foreach.
            string[] carType = { "Ford", "BMW", "Yugo", "HondA" };
            foreach(string c in carType)
            {
                Console.WriteLine(c);

                int[] myInt = { 10, 20, 30, 40 };
                foreach(int i in myInt)
                {
                    Console.WriteLine(i);
                }
            }

        }

        private static void ForLoopexamples()
        {
//A basic for loop
//Note! "i" is only visible within the scope of the for loop
for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0}",i);
            }
// i is not visible here

        }
    }
}

using System;

// namespace
namespace ConsoleApp2TraversyMediaNumGuess
{
    // main class
    class Program
    {
        // entry point method (function)
        static void Main(string[] args)
        {
            GetAppInfo(); //run GetAppInfo Function    
            GreetUser(); //run GreetUser Function

            // lets create a loop so user can play game continuously
            while (true)
            {

                // first Random is the class, lowercase random is a variable, create a "new Random" object or instance of the class
                Random random = new Random();
                //initialize random number
                int correctNumber = random.Next(1, 10);


                // initialize guess variable
                int guess = 0;

                // ask the user for a number
                Console.WriteLine("Guess a number between 1 and 9");

                // while is not correct
                while (guess != correctNumber)
                {
                    // get users input
                    string input = Console.ReadLine();

                    // make sure it is a number and not anything else
                    if (!int.TryParse(input, out guess))
                    {

                        // print error message
                        PrintColorMessage(ConsoleColor.Red, "Sorry, not a number - please enter actual number: ");
                        // keep going
                        continue;
                    }

                    // cacst to interger and put into guess variable
                    guess = Int32.Parse(input);

                    // Match the information stored in guess variable to information stored in correctNumber variable
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "wrong number please try again ");
                    }

                }

                // output success message
                PrintColorMessage(ConsoleColor.Yellow, "you guessed right!");

                // ask user to play again
                Console.WriteLine("Play Again []Y or N");
                //get the answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    // returns outside of loop
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            // set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sara";

            // let's get fancy and change the color of the text
            Console.ForegroundColor = ConsoleColor.Green;

            // lets tell our users what app is- and try using some fun variables
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // let's change the color back
            Console.ResetColor();
        }
        static void GreetUser()
        {
            // lets get the users name
            Console.WriteLine("What is your name? ");
            // save input from user
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", userName);
        }

        //print color message

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // let's get fancy and change the color of the text
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            // let's change the color back
            Console.ResetColor();
        }
    }
}
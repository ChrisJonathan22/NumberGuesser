using System;

// Namespace
namespace NumberGuesser
{
// Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // START HERE
            AppInfo.GetAppInfo(); // Run GetAppInfo function.

            Greeting.GreetUser(); // Ask for users name and greet.

            while(true) {
            // Init correct number
            int correctNumber = CreateRandomNumber.GenerateRandomNumber(0,10);

            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10.");

            // While guess is not correct
            while(guess != correctNumber) {
                // Get users input
                string input = Console.ReadLine();

                // Make sure it's a number
                if(!int.TryParse(input, out guess)) {

                    // Print error message
                    ErrorMessage.GetErrorMessage();

                    // Keep going
                    continue;
                }
                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber) {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Red;

                    // Tell user it's the wrong number
                    Console.WriteLine("Wrong number, please try again.");

                    // Reset text color
                    Console.ResetColor();
                }
            }
                // Output success message
                SuccessMessage.GetSuccesMessage();
                
                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer != "Y") {
                    return;
                }
            }    
        }
    }

    public class CreateRandomNumber {
        public static int GenerateRandomNumber(int num1, int num2) {
            // Create a new random object
            Random random = new Random();

            // Return random number
            int randomNumber = random.Next(num1, num2);
            return randomNumber;
        }
    }
    public class Greeting {
        public static void GreetUser() {
            // Ask users name
            Console.WriteLine("Please enter your name...");

            // Get user input
            string inputName = Console.ReadLine();

            // Output message to user
            Console.WriteLine($"Greetings {inputName} :), let's play a game...");
        }
    }
    public class AppInfo {
        public static void GetAppInfo() {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Chris Jonathan";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }
    }
    public class SuccessMessage {
        public static void GetSuccesMessage () {
            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Tell user it's the right number
            Console.WriteLine("You are CORRECT!!!");

            // Reset text color
            Console.ResetColor();

            // Ask to play again
            Console.WriteLine("Play Again? [Y or N]");
        }
    }
     public class ErrorMessage {
        public static void GetErrorMessage () {
            // Change text color
            Console.ForegroundColor = ConsoleColor.Red;

            // Tell user it's not a number
            Console.WriteLine("Please enter a number.");

            // Reset text color
            Console.ResetColor();
        }
    }
}

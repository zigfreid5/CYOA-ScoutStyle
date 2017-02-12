using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            output("Hello World!");
            output("What is your name?");

            var name = getInput();
            output(" ");
            output("Hello " + name + ". Welcome to your own adventure.");
            output("You will be presented with many situations. Choose your actions wisely...");
            
            waitForContinue();

            output("Situation: Levi is making lots of noise. Do you tell him to stop it?");
            output("y for yes, n for no");

            var answer = getInput();
            
            if(answer == "y") {
                output("Good choice!");
                tellLeviToStopYelling();
            } else {
                output("Wrong. Levi yelled too much and you went deaf. Game over.");
                return;
            }

            waitForContinue();

            output("Situation: Colin has a bazooka. Fight or flight?");
            answer = getInput();
            if(answer.ToLower() == "fight") {
                output("Good choice! You quickly hit him on the head with a bat. " +
                "He falls and drops the bazooka. You pick it up and throw it in the river.");
            } else {
                output("Wrong! Colin turns as you run away and launches a bazooka at your feet. You now have no feet. Game over.");
                return;
            }
            waitForContinue();
            
            output("Situation: Josh turns into a tiny ninja and attacks you. Do you use karate or kung fu?");
            answer = getInput();
            if(answer == "karate") {
                output("Bad choice! Josh breaks you in two because you weren't cool enough to know kung fu. Game over!");
                return;
            } else {
                output("Nice! Josh's skills were no match for your kung fu awesomeness.");
            }

            waitForContinue();
            
            output("Situation: Jensen got a new phone, but you recently learned some pretty sweet hacking skills. Do you try to hack it?");
            output("Press y for yes, n for no.");
            answer = getInput();
            if(answer == "y") {
                output("The FBI finds out, and instead of taking you to jail,they hire you for your sweet hacking skills. You make LOADS of dough and retire at age 11.");
                youWin();
            } else {
                output("Bad choice. Jensen spends too much time on his phone, stops paying attention in class, and turns into a homeless man. Game over.");
                return;
            }
        }

        public static void output(string message) {
            Console.WriteLine(message);
        }

        public static void tellLeviToStopYelling() {
            output("LEVI!!! Stop yelling!");
        }

        public static String getInput() {
            return Console.ReadLine();
        }

        public static void waitForContinue() {
            output("Press Enter to continue...");
            getInput();
            return;
        }

        public static void youWin() {
            output("YOU WIN!!! Congratulations!");
            output("Game Over");
        }

    }
}

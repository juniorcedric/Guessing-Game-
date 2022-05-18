// keep only system 'caus only one that is needed to work with the console
using System;

// Namespace = name of the project
namespace TutoBrad_guessingNumberGame_13052022
{
    // Principal class that is going to be run = Main Class -> class Program
    internal class Program
    {
        // Entry Point, first Code to be 
        // Static = no instance of the fonction = NO COPY ;
        static void Main(string[] args)
        {
            GetAppInfo();

            // SET CORRECT NUMBER
            while (true)
            {
                // int correctNumber = 7;
                // Create Random Number to guess
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // INIT GUESS VAR

                int guess = 0;

                // ASK USER FOR WILD GUESS
                Console.WriteLine("GUESS THE NUMBER");

                while (guess != correctNumber)
                {
                    // GET USER NUMBER
                    string inputNumber = Console.ReadLine();

                    // MAKE SURE IT S NUMBER
                    if (!int.TryParse(inputNumber, out guess))
                    {

                        // SET VERSION TEXT COLOR

                        Console.ForegroundColor = ConsoleColor.Red;

                        // APP INFOS

                        Console.WriteLine("ONLY NUMBERS ALOUD ");

                        // RESET TEXT COLOR 
                        Console.ResetColor();
                        continue;
                    }

                    // TRANSFORM USER STRING TO INT
                    guess = Int32.Parse(inputNumber);

                    // Match the guess to the real Number
                    if (guess != correctNumber)
                    {
                        // SET VERSION TEXT COLOR

                        Console.ForegroundColor = ConsoleColor.Red;

                        // APP INFOS

                        Console.WriteLine("TRY AGAIN");

                        // RESET TEXT COLOR 
                        Console.ResetColor();
                    }

                }
                // WHENN USER SUCCESFULLY FIND THE RIGHT NUMBER

                // SET VERSION TEXT COLOR

                Console.ForegroundColor = ConsoleColor.Yellow;

                // APP INFOS

                Console.WriteLine(" RIGHT GUESS, BRAVO !! ");

                // RESET TEXT COLOR 
                Console.ResetColor();

                // ASK TO PLAY AGAIN
                Console.WriteLine(" WANNA PLAY AGAIN ? [ Y or N ]");

                //ANSWER
                string answer = Console.ReadLine().ToUpper();
                
                if(answer == "Y")
                {
                    continue;

                }
                else if(answer == "N")
                {
                    return;
                }
                else 
                {
                    return;
                }
            }


        }
        static void GetAppInfo()
        {
            // SET APP NAME AND vERSION

            string name = "NUMBER GUESSER";
            String appVersion = "1.0.0";
            String author = "MIO-TNU";

            // SET VERSION TEXT COLOR

            Console.ForegroundColor = ConsoleColor.Green;

            // APP INFOS

            Console.WriteLine("Game {0 }: Version {1} by {2} ", name, appVersion, author);

            // RESET TEXT COLOR 
            Console.ResetColor();

            // ASK USERS NAME 
            Console.WriteLine("what is your name ? ");

            // GET USER Name TO RESUSE
            String inputName = Console.ReadLine();

            Console.WriteLine(" Hello {0}, let us play a game...", inputName);

        }

          
    }
}

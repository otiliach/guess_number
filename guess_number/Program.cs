namespace guess_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GuessNumberGame();
        }

        private static void GuessNumberGame()
        {
            WriteGameName();

            Random rnd = new Random();
            int rNumber = rnd.Next(0, 101);
            int guess;         
           
            do
            {
                guess = InputGuessNumber();

                 if (guess < rNumber)
                {
                    Console.WriteLine("Your number was too small, try again.");
                }
                else
                if (guess > rNumber)
                {
                    Console.WriteLine("Your number was too big, try again.");
                }

            } while (rNumber != guess);

            Console.Write("You guessed! :) The answer was {0}.", rNumber);
        }

        private static int InputGuessNumber()
        {
            int guess;
            string? inputStr;
            Console.Write("Enter a number between 0 and 100: ");

            inputStr = Console.ReadLine();

            while (!int.TryParse(inputStr, out guess))
            {
                Console.Write("Invalid enter! You must enter a number: ");
                inputStr = Console.ReadLine();
            }
            
            return guess;
        }

        private static void WriteGameName()
        {
            string gameName = "***Guess the number***";
            Console.WriteLine(string.Format("{0," + ((Console.WindowWidth / 2) + (gameName.Length / 2)) + "}", gameName));
            Console.WriteLine();
        }
    }
}
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
            int rNumber = rnd.Next(0, 100);
            int? guess = null;         
           
            do
            {
                guess = InputGuessNumber();


                if (guess == rNumber)
                    break;
                else
                    if (guess < rNumber)
                {
                    Console.WriteLine("Your number was too small, try again.");
                }
                else
                {
                    Console.WriteLine("Your number was too big, try again.");
                }

            } while (rNumber != guess);

            Console.Write("You guessed! :) The answer was {0}.", rNumber);
        }

        private static int? InputGuessNumber()
        {
            int? guess = null;
            string inputStr;
            Console.Write("Enter a number between 0 and 100: ");

            while (guess == default)
            {
                inputStr = Console.ReadLine() ?? string.Empty;
                guess = int.TryParse(inputStr, out int temp) ? temp : default(int?);

                if (guess == default)
                    Console.Write("Invalid enter! You must enter a number: ");
            }
            return guess;
        }

        private static void WriteGameName()
        {
            string gameName = "***Guess the number***\n";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (gameName.Length / 2)) + "}", gameName));
        }
    }
}
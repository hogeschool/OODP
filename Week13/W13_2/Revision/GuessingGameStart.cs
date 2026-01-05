// In this game we have to guess a secret condition for a number.
// Right now the condition is always that it has to be even.
// ASSIGNMENT: make it so that the constructor takes a function
// that replaces the `guess % 2 == 0`.

namespace GuessingGame_Assignment;

public class GuessingGame
{

    public GuessingGame()
    {

    }

    public void Play()
    {
        int guess;
        do
        {
            Console.WriteLine($"Guess a number that meets the secret condition!");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out guess))
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }

            if (guess % 2 == 0)
            {
                Console.WriteLine($"Correct! {guess} meets the condition.");
                return;
            }
            else
            {
                Console.WriteLine("Wrong guess. Try again!");
            }
        } while (true);
    }
}
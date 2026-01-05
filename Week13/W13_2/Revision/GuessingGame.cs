namespace GuessingGame_Solution;

public class GuessingGame
{
    private readonly Func<int, bool> _predicate;

    public GuessingGame(Func<int, bool> predicate)
    {
        _predicate = predicate;
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

            if (_predicate(guess))
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
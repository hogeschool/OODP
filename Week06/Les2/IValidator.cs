
public interface IValidator<T>
{
    public string ErrorExplanation { get; }
    bool IsValid(T value);
}

public class EmailValidator : IValidator<string>
{
    public string ErrorExplanation => "The value must be a valid email address.";

    public bool IsValid(string value)
    {
        return value.Contains("@") && value.Contains(".");
    }
}

public interface IStringValidator : IValidator<string>
{
    
}

public class PasswordValidator : IStringValidator
{
    public string ErrorExplanation => "The password must be at least 8 characters long and contain a number.";

    public bool IsValid(string value)
    {
        return value.Length >= 8 && value.Any(char.IsDigit);
    }
}

public class UsernameValidator : IStringValidator
{
    public string ErrorExplanation => "The username must be at least 5 characters long and contain only letters and numbers.";

    public bool IsValid(string value)
    {
        return value.Length >= 5 && value.All(char.IsLetterOrDigit);
    }
}

public interface IParseInput<T>
{
    bool TryParse(string input, out T result);
}

public class ReadValueFromConsole<T>
{
    public required IEnumerable<IValidator<T>> Validators { get; set; }
    public required IParseInput<T> Parser { get; set; }
    
    public T GetValue()
    {
        T result = default;
        bool valid = false;
        while (!valid)
        {
            string input = Console.ReadLine();
            if (Parser.TryParse(input, out result))
            {
                valid = false;
                foreach (var validator in Validators)
                {
                    if (!validator.IsValid(result))
                    {
                        Console.WriteLine(validator.ErrorExplanation);
                        valid = false;
                        break;
                    }
                    valid = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, try again");
            }
        }
        return result;
    }
}
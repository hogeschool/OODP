using System;

namespace Les02;

public interface IStringValidator
{
    bool IsValid(string value);

    string GetErrorMessage();
}

public class NotEmptyStringValidator : IStringValidator
{
    public string GetErrorMessage()
    {
        throw new NotImplementedException();
    }

    public bool IsValid(string value)
    {
        return !string.IsNullOrEmpty(value);
    }
}

public class MaxLengthStringValidator : IStringValidator
{
    public int MaxLength { get; }

    public MaxLengthStringValidator(int maxLength)
    {
        this.MaxLength = maxLength;
    }

    public bool IsValid(string value)
    {
        return value.Length <= this.MaxLength;
    }

    public string GetErrorMessage()
    {
        throw new NotImplementedException();
    }
}

public class ContainsCharacterStringValidator : IStringValidator
{
    public char Character { get; }

    public ContainsCharacterStringValidator(char character)
    {
        this.Character = character;
    }

    public bool IsValid(string value)
    {
        return value.Contains(this.Character);
    }

    public string GetErrorMessage()
    {
        throw new NotImplementedException();
    }
}

public class AndStringValidator : IStringValidator
{
    public IEnumerable<IStringValidator> Validators { get; }
    public AndStringValidator(IEnumerable<IStringValidator> validators)
    {
        this.Validators = validators;
    }

    public bool IsValid(string value)
    {
        foreach (IStringValidator validator in this.Validators)
        {
            if (!validator.IsValid(value))
            {
                return false;
            }
        }
        return true;
    }

    public string GetErrorMessage()
    {
        throw new NotImplementedException();
    }
}

public static class StringValidatorFactory
{
    public static IStringValidator EmailValidator => new AndStringValidator(new List<IStringValidator>
    {
        new NotEmptyStringValidator(),
        new ContainsCharacterStringValidator('@'),
        new ContainsCharacterStringValidator('.'),
        new MaxLengthStringValidator(20),
    });

    public static IStringValidator UsernameValidator => new AndStringValidator(new List<IStringValidator>
    {
        new NotEmptyStringValidator(),
        new MaxLengthStringValidator(15),
    });
}

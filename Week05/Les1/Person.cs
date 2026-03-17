using System;
using System.Security.Cryptography;

namespace Les1;

public class Person
{
    protected string firstName = string.Empty;
    protected string lastName = string.Empty;

    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value ?? throw new ArgumentNullException(); }
    }

    public int Age { get; private set; } = 0;

    public string Gender
    {
        get;
        set
        {
            field = value == "Male" || value == "Female"
                ? value
                : throw new ArgumentException("Invalid gender");
        }
    } = "Female";

    public virtual string FullName => $"{this.FirstName} {this.LastName}";
}

public class RoyalPerson : Person
{
    public override string FullName => $"His/Her Royal Highness {base.FullName}";

    public readonly int age;

    public string Title { get; } = "Ridder";

    public RoyalPerson()
    {
        age = 10;
        Title = "King";
    }

    public void Hi()
    {
        this.firstName.ToUpper();
        Title = "King";
    }
}

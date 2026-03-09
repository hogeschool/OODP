class Person
{
    public string BSN;
    public string Name;
    public int Age;

    public Person(string bsn, string name, int age)
    {
        BSN = bsn;
        Name = name;
        Age = age;
    }

    // Constructor with 2 parameters (No age)
    public Person(string bsn, string name) : this(bsn, name, 0) { }

    // Constructor with with 2 parameters and BSN as int
    public Person(int bsn, string name) : this(Convert.ToString(bsn), name) { }

    // Constructor which takes in a Person and copies information from there.
    // The unofficial name for this is 'copy constructor'.
    public Person(Person other) : this(other.BSN, other.Name, other.Age) { }
    // This is the same as above
    // public Person(Person other)
    // {
    //     this.BSN = other.BSN;
    //     this.Name = other.Name;
    //     this.Age = other.Age;
    // }

    public void IncreaseAge() => Age++;
    public string ShareID() => $"BSN: {BSN}";
}
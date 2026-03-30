class Person : IEquatable<Person>
{
    public string? Name { get; set; }
    public int Age { get; set; }

    //Override the Object.Equals method to support comparison with other types of objects
    public override bool Equals(object? obj) => Equals(obj as Person);

    //Implement the IEquatable interface method
    public bool Equals(Person? other)
    {
        if (other is null) { return false; }

        //Compare name and age
        return Name == other.Name && Age == other.Age;
    }
}
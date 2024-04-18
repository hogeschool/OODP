public class Person : IEquatable<Person>
{
    public string? Name { get; set; }
    public int Age { get; set; }

    //Implement the IEquatable interface method
    public bool Equals(Person other)
    {
        if (other is null)
        {
            return false;
        }

        //Compare name and age
        return (this.Name == other.Name) && (this.Age == other.Age);
    }

    //Override the Object.Equals method to support comparison with other types of objects
    public override bool Equals(object obj)
    {
        return Equals(obj as Person);
    }

    public static bool operator ==(Person p1, Person p2)
    {
        if (p1 is null)
            return p2 is null;
        return p1.Equals(p2);
    }
    public static bool operator !=(Person p1, Person p2) => !(p1 == p2);
}
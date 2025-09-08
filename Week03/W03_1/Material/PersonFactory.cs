/*
    Create a PersonFactory class that generates John Doe and Jane Doe instances
    with a random age (from 0 up to the MaxAge defined in the Person class)
*/
public static class PersonFactory
{
    public static Random Rand = new Random();

    public static int GenerateRandomAge()
    {
        return Rand.Next(0, Person.MaxAge + 1);
    }

    public static Person CreateJohnDoe()
    {
        return new Person("John Doe", GenerateRandomAge());
    }

    public static Person CreateJaneDoe()
    {
        return new Person("Jane Doe", GenerateRandomAge());
    }
}
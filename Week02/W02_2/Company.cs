public class Company
{
    public Person Founder;
    public Company(string founderName) => Founder = new Person(founderName);
}
public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }

    public Student(string name, int age, int grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Grade: {Grade}";
    }

    // Implement the method from the IComparable<Student> interface
    public int CompareTo(Student other)
    {
        // if null return 1
        if (other == null) { return 1; }

        // Compare by name first
        int nameComparison = this.Name.CompareTo(other.Name);
        if (nameComparison != 0)
            return nameComparison;

        // If name is the same, compare by age
        int ageComparison = this.Age.CompareTo(other.Age);
        if (ageComparison != 0)
            return ageComparison;

        // If age is also the same, compare by grade
        return this.Grade.CompareTo(other.Grade);
        // Grade high to low:
        // return -1* this.Grade.CompareTo(other.Grade);
        // or
        // return other.Grade.CompareTo(this.Grade);
    }
}
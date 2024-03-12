public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int GradeLevel { get; set; }

    //Implement the IComparable interface method
    public int CompareTo(Student other)
    {
        if (other == null) return 1;

        //Compare by grade level first
        int gradeComparison = this.GradeLevel.CompareTo(other.GradeLevel);
        if (gradeComparison != 0)
        {
            return gradeComparison;
        }

        //If grade level is the same, compare by age
        int ageComparison = this.Age.CompareTo(other.Age);
        if (ageComparison != 0)
        {
            return ageComparison;
        }

        //If age is also the same, compare by name
        return this.Name.CompareTo(other.Name);
    }
}
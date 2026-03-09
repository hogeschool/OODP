class Student : Person
{
    // Extra fields
    public string StudentID;
    public int YearEnrolled;

    // Constructor that takes in all fields from Person and the Student ID
    public Student(string bsn, string name, int age, string studentID, int yearEnrolled)
        : base(bsn, name, age)
    {
        StudentID = studentID;
        YearEnrolled = yearEnrolled;
    }

    // LengthOfStudy a method relevant to a student and not a Person
    public int LengthOfStudy(int currentYear) => currentYear - YearEnrolled;
}
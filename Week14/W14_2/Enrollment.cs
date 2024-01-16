class Enrollment { 
    public Student Student;
    int studentID;
    public Course Course;
    int courseID;
    public double Grade;

    public Enrollment(Student student, Course course) { Student = student; Course = course; }
    public Enrollment(Student student, Course course, double grade):this(student, course)=>Grade = grade;
}
public class CourseResult<T>
{
    public string Name { get; }
    public T Grade { get; set; }

    public CourseResult(string name, T grade)
    {
        Name = name;
        Grade = grade;
    }

    //How can we determine whether the grade is sufficient?
    //We will learn this later in the course!
}
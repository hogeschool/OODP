public class CourseFormField<T>
{
    public string Name { get; }
    public T Grade { get; set; }

    public CourseFormField(string name, T grade)
    {
        Name = name;
        Grade = grade;
    }

    public virtual bool IsPass()
    {
        if (Grade is bool)
            return Convert.ToBoolean(Grade);
        if (Grade is double)
            return Convert.ToDouble(Grade) > 5.5;
        return false;
    }

    public void ResetForm() => Grade = default;
}

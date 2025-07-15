public class CourseFormFieldText : CourseFormField<string>
{
    public static readonly List<string> PassList =
        ["Satisfactory", "Good", "Outstanding"];
    public static readonly List<string> FailList =
        ["Poor", "Unsatisfactory"];

    public CourseFormFieldText(string name, string grade)
        : base(name, grade) { }

    public override bool IsPass()
    {
        if (!PassList.Contains(Grade) &&
            !FailList.Contains(Grade))
        {
            throw new Exception("Grade not in either pass or fail list ");
        }
        return PassList.Contains(Grade);
    }
}

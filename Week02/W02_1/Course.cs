class Course
{
    // Fields
    public string Name;
    public int Credits;

    // Constructor
    // Similar to Python's __init__(self, ...)
    // Notice that it has the same name as the class, and no return type
    public Course(string name, int credits)
    {
        //The keyword 'this' is more or less equivalent to Python's 'self'.
        //Using 'this' is optional, but can sometimes make code more clear.
        //For example, in the constructor it can prevent
        //unexpected behavior due to faulty value assignment.
        this.Name = name;
        this.Credits = credits;
    }

    // Method
    // Notice:
    // - the absence of the 'static' keyword
    // - this is a method-bodied expression
    public string Info() => $"Course {Name} is worth {Credits} credits";
}
